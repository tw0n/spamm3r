﻿using System;
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
    public partial class spamm3r : Form
    {
        public spamm3r()
        {
            InitializeComponent();

            if (Properties.Settings.Default.firstTime == "true")
            {
                FirstTime ftime = new FirstTime();
                ftime.form1 = this;
                ftime.Show();
                this.Enabled = false;
            }

            verisonLabel.Text = Properties.Settings.Default.version;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string toEmail = toBox.Text;
            string fromEmail = fromBox.Text;
            string fromName = fromNameBox.Text;
            string subject = subjectBox.Text;
            string msg = msgBox.Text;

            if (toEmail == "" | fromEmail == "")
            {
                MessageBox.Show("No to email or from email was detected.");
            }

            else
            {
                sendTimer.Enabled = true;
                toBox.Enabled = false;
                fromBox.Enabled = false;
                fromNameBox.Enabled = false;
                subjectBox.Enabled = false;
                msgBox.Enabled = false;
                sendButton.Enabled = false;
                
                MailMessage mail = new MailMessage();
                try
                {
                    mail.From = new System.Net.Mail.MailAddress(fromEmail, fromName);
                }
                catch
                {
                    if ((MessageBox.Show("Put in a proper email ;]") == DialogResult.OK))
                    {
                        sendTimer.Enabled = false;
                        toBox.Enabled = true;
                        fromBox.Enabled = true;
                        fromNameBox.Enabled = true;
                        subjectBox.Enabled = true;
                        msgBox.Enabled = true;
                        sendButton.Enabled = true;
                        progressBar1.Value = 0;
                    }
                    else
                    {
                        SmtpClient smtp = new SmtpClient();
                        smtp.Port = 587;
                        smtp.Host = "relay.jangosmtp.net";
                        mail.To.Add(new MailAddress(toEmail));
                        mail.Body = msg;
                        try
                        {
                            smtp.Send(mail);
                        }
                        catch
                        {
                            if ((MessageBox.Show("Message wasn't sent :[ Did you setup your JangoSMTP account?") == DialogResult.OK))
                            {
                                sendTimer.Enabled = false;
                                toBox.Enabled = true;
                                fromBox.Enabled = true;
                                fromNameBox.Enabled = true;
                                subjectBox.Enabled = true;
                                msgBox.Enabled = true;
                                sendButton.Enabled = true;
                                progressBar1.Value = 0;
                            }
                        }
                    }
                }
            }
        }

        private void sendTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1800;
            progressBar1.Step = 1;
            progressBar1.PerformStep();

            if (progressBar1.Value == 1799)
            {
                if ((MessageBox.Show("Message sent! :]") == DialogResult.OK))
                {
                    sendTimer.Enabled = false;
                    toBox.Enabled = true;
                    fromBox.Enabled = true;
                    fromNameBox.Enabled = true;
                    subjectBox.Enabled = true;
                    msgBox.Enabled = true;
                    sendButton.Enabled = true;
                    progressBar1.Value = 0;
                }
            }
        }

        private void licenseBox_Click(object sender, EventArgs e)
        {
            Process.Start("http://creativecommons.org/licenses/by-nc/3.0/");
        }

        private void updatesLabel_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/tw0n/spamm3r");
        }
    }
}