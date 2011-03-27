using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FirstTime : Form
    {
        public FirstTime()
        {
            InitializeComponent();
        }

        internal Form form1;

        private void btn_understand_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.firstTime = "false";
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
