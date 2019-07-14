using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Drawing;
using System.Threading;

namespace The_Network_Status_Displayer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow myMainWindow = new MainWindow();
            Application.Run(myMainWindow);
            //new pingGer("192.168.0.1", myMainWindow.PingToModem);
            //myMainWindow.PingToWT.Text = "1919";
            //new pingGer("8.8.8.8", myMainWindow.PingTo8888);
            //new pingGer("162.213.60.88", myMainWindow.PingToWOWS);
            //new pingGer("warthunder.com", myMainWindow.PingToWT);
        }
    }

    public class pingGer
    {
        private const int capacityOfPool = 40;
        private const int pingPeriod = 200;
        private const float lerpAverageWeight = 0.5f;
        int avgPing = 810;
        string ip;
        int timeout = 1919;
        byte[] buffer = Encoding.ASCII.GetBytes("114514");
        Label myLabel;
        List<int> pingPool = new List<int>();
        public pingGer(String ipp, Label mylabel)
        {
            ip = ipp;
            myLabel = mylabel;
            for (int i = 0; i < capacityOfPool; ++i)
            {
                pingPool.Add(810);
            }
            ThreadStart startLoop = new ThreadStart(continuousLoop);
            (new Thread(startLoop)).Start();
        }

        private void continuousLoop()
        {
            ThreadStart pingItt = new ThreadStart(pingIt);
            while (myLabel.Parent != null)
            {
                avgPing = (int) pingPool.Average();
                float whiteLevel = (255f * Math.Max((1 - (Math.Min(avgPing, 1919) / (float)timeout)), 0)) * (1-lerpAverageWeight) + (myLabel.BackColor.G * lerpAverageWeight);
                myLabel.BackColor = Color.FromArgb(255, (int)whiteLevel, (int)whiteLevel);
                myLabel.Text = myLabel.Name + ": \t"+ avgPing + " ms"; 
                Thread.Sleep(pingPeriod);
                (new Thread(pingItt)).Start();

            }
        }

        private void pingIt()
        {
            Ping sender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;
            PingReply reply = sender.Send(ip, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {
                float lerped = reply.RoundtripTime * (1 - lerpAverageWeight) + avgPing * (lerpAverageWeight);
                pushIn((int)lerped);
            }
            else
            {
                pushIn(9999);
            }
        }

        private void pushIn(int pingu)
        {
            pingPool.Insert(0, pingu);
            pingPool.RemoveAt(capacityOfPool);
        }
    }
}
