using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FirstTime : Form
    {
        public FirstTime()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        internal Form form1;

        private void btn_understand_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.firstTime = "false";
            Properties.Settings.Default.Save();
            form1.Enabled = true;
            this.Close();
        }

        private void tutLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/tw0n/spamm3r/wiki/JangoSMTP-Authorization");
        }
    }
}
