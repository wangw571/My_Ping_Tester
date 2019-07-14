namespace The_Network_Status_Displayer
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PingToModem = new System.Windows.Forms.Label();
            this.PingTo8888 = new System.Windows.Forms.Label();
            this.PingToWOWS = new System.Windows.Forms.Label();
            this.PingToWT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PingToModem
            // 
            this.PingToModem.AutoSize = true;
            this.PingToModem.Location = new System.Drawing.Point(13, 13);
            this.PingToModem.Name = "PingToModem";
            this.PingToModem.Size = new System.Drawing.Size(26, 13);
            this.PingToModem.TabIndex = 0;
            this.PingToModem.Text = "0ms";
            // 
            // PingTo8888
            // 
            this.PingTo8888.AutoSize = true;
            this.PingTo8888.Location = new System.Drawing.Point(13, 26);
            this.PingTo8888.Name = "PingTo8888";
            this.PingTo8888.Size = new System.Drawing.Size(26, 13);
            this.PingTo8888.TabIndex = 0;
            this.PingTo8888.Text = "0ms";
            // 
            // PingToWOWS
            // 
            this.PingToWOWS.AutoSize = true;
            this.PingToWOWS.Location = new System.Drawing.Point(13, 39);
            this.PingToWOWS.Name = "PingToWOWS";
            this.PingToWOWS.Size = new System.Drawing.Size(26, 13);
            this.PingToWOWS.TabIndex = 0;
            this.PingToWOWS.Text = "0ms";
            // 
            // PingToWT
            // 
            this.PingToWT.AutoSize = true;
            this.PingToWT.Location = new System.Drawing.Point(13, 52);
            this.PingToWT.Name = "PingToWT";
            this.PingToWT.Size = new System.Drawing.Size(26, 13);
            this.PingToWT.TabIndex = 0;
            this.PingToWT.Text = "0ms";
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(120, 73);
            this.Controls.Add(this.PingToWT);
            this.Controls.Add(this.PingToWOWS);
            this.Controls.Add(this.PingTo8888);
            this.Controls.Add(this.PingToModem);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Tester";
            this.Activated += new System.EventHandler(this.MainWindow_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label PingToModem;
        public System.Windows.Forms.Label PingTo8888;
        public System.Windows.Forms.Label PingToWOWS;
        public System.Windows.Forms.Label PingToWT;
    }
}

