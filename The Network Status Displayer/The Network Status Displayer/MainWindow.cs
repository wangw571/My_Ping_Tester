using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Network_Status_Displayer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        pingGer mo;
        pingGer eight;
        pingGer wows;
        pingGer wt;
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            mo = new pingGer("192.168.0.1", this.PingToModem);
            eight = new pingGer("8.8.8.8", this.PingTo8888);
            wows = new pingGer("162.213.60.88", this.PingToWOWS);
            wt = new pingGer("warthunder.com", this.PingToWT);
            PingToModem.Text = ("ん？");
        }
    }
}
