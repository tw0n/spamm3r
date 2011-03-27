namespace WindowsFormsApplication1
{
    partial class twon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(twon));
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.fromNameLabel = new System.Windows.Forms.Label();
            this.fromNameBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.sendButton = new System.Windows.Forms.Button();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.msgLabel = new System.Windows.Forms.Label();
            this.subjectBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.fromBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toBox = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.sendTimer = new System.Windows.Forms.Timer(this.components);
            this.infoLabel = new System.Windows.Forms.Label();
            this.versionLabelPre = new System.Windows.Forms.Label();
            this.verisonLabel = new System.Windows.Forms.Label();
            this.licenseBox = new System.Windows.Forms.PictureBox();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.updatesLabel = new System.Windows.Forms.Label();
            this.infoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.fromNameLabel);
            this.infoBox.Controls.Add(this.fromNameBox);
            this.infoBox.Controls.Add(this.progressBar1);
            this.infoBox.Controls.Add(this.sendButton);
            this.infoBox.Controls.Add(this.msgBox);
            this.infoBox.Controls.Add(this.msgLabel);
            this.infoBox.Controls.Add(this.subjectBox);
            this.infoBox.Controls.Add(this.subjectLabel);
            this.infoBox.Controls.Add(this.fromBox);
            this.infoBox.Controls.Add(this.fromLabel);
            this.infoBox.Controls.Add(this.toBox);
            this.infoBox.Controls.Add(this.toLabel);
            this.infoBox.Location = new System.Drawing.Point(13, 13);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(456, 395);
            this.infoBox.TabIndex = 0;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Information";
            // 
            // fromNameLabel
            // 
            this.fromNameLabel.AutoSize = true;
            this.fromNameLabel.Location = new System.Drawing.Point(254, 64);
            this.fromNameLabel.Name = "fromNameLabel";
            this.fromNameLabel.Size = new System.Drawing.Size(64, 13);
            this.fromNameLabel.TabIndex = 11;
            this.fromNameLabel.Text = "From Name:";
            // 
            // fromNameBox
            // 
            this.fromNameBox.Location = new System.Drawing.Point(257, 81);
            this.fromNameBox.Name = "fromNameBox";
            this.fromNameBox.Size = new System.Drawing.Size(188, 20);
            this.fromNameBox.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(94, 364);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(351, 21);
            this.progressBar1.TabIndex = 77;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(13, 363);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send!";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(13, 163);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgBox.Size = new System.Drawing.Size(432, 194);
            this.msgBox.TabIndex = 6;
            // 
            // msgLabel
            // 
            this.msgLabel.AutoSize = true;
            this.msgLabel.Location = new System.Drawing.Point(10, 147);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(53, 13);
            this.msgLabel.TabIndex = 6;
            this.msgLabel.Text = "Message:";
            // 
            // subjectBox
            // 
            this.subjectBox.Location = new System.Drawing.Point(13, 124);
            this.subjectBox.Name = "subjectBox";
            this.subjectBox.Size = new System.Drawing.Size(237, 20);
            this.subjectBox.TabIndex = 5;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(10, 108);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(46, 13);
            this.subjectLabel.TabIndex = 4;
            this.subjectLabel.Text = "Subject:";
            // 
            // fromBox
            // 
            this.fromBox.Location = new System.Drawing.Point(10, 81);
            this.fromBox.Name = "fromBox";
            this.fromBox.Size = new System.Drawing.Size(240, 20);
            this.fromBox.TabIndex = 3;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(10, 64);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 2;
            this.fromLabel.Text = "From:";
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(10, 37);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(240, 20);
            this.toBox.TabIndex = 1;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(7, 20);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "To:";
            // 
            // sendTimer
            // 
            this.sendTimer.Interval = 10;
            this.sendTimer.Tick += new System.EventHandler(this.sendTimer_Tick);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(541, 219);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(157, 13);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "Made by tw0n, get spamming. :]";
            // 
            // versionLabelPre
            // 
            this.versionLabelPre.AutoSize = true;
            this.versionLabelPre.Location = new System.Drawing.Point(578, 232);
            this.versionLabelPre.Name = "versionLabelPre";
            this.versionLabelPre.Size = new System.Drawing.Size(45, 13);
            this.versionLabelPre.TabIndex = 3;
            this.versionLabelPre.Text = "Version:\r\n";
            // 
            // verisonLabel
            // 
            this.verisonLabel.AutoSize = true;
            this.verisonLabel.Location = new System.Drawing.Point(619, 232);
            this.verisonLabel.Name = "verisonLabel";
            this.verisonLabel.Size = new System.Drawing.Size(0, 13);
            this.verisonLabel.TabIndex = 4;
            // 
            // licenseBox
            // 
            this.licenseBox.Cursor = System.Windows.Forms.Cursors.Help;
            this.licenseBox.Image = global::WindowsFormsApplication1.Properties.Resources.license;
            this.licenseBox.Location = new System.Drawing.Point(581, 393);
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.Size = new System.Drawing.Size(80, 15);
            this.licenseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.licenseBox.TabIndex = 5;
            this.licenseBox.TabStop = false;
            this.licenseBox.Click += new System.EventHandler(this.licenseBox_Click);
            // 
            // pictBox
            // 
            this.pictBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.bigico;
            this.pictBox.Location = new System.Drawing.Point(527, 13);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(186, 192);
            this.pictBox.TabIndex = 1;
            this.pictBox.TabStop = false;
            // 
            // updatesLabel
            // 
            this.updatesLabel.AutoSize = true;
            this.updatesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatesLabel.Location = new System.Drawing.Point(534, 364);
            this.updatesLabel.Name = "updatesLabel";
            this.updatesLabel.Size = new System.Drawing.Size(179, 26);
            this.updatesLabel.TabIndex = 6;
            this.updatesLabel.Text = "For updates and more, visit the repo:\r\n https://github.com/tw0n/spamm3r";
            this.updatesLabel.Click += new System.EventHandler(this.updatesLabel_Click);
            // 
            // twon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 420);
            this.Controls.Add(this.updatesLabel);
            this.Controls.Add(this.licenseBox);
            this.Controls.Add(this.verisonLabel);
            this.Controls.Add(this.versionLabelPre);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.pictBox);
            this.Controls.Add(this.infoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "twon";
            this.Text = "tw0n spamm3r";
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.licenseBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Label msgLabel;
        private System.Windows.Forms.TextBox subjectBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox fromBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label fromNameLabel;
        private System.Windows.Forms.TextBox fromNameBox;
        private System.Windows.Forms.Timer sendTimer;
        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label versionLabelPre;
        private System.Windows.Forms.Label verisonLabel;
        private System.Windows.Forms.PictureBox licenseBox;
        private System.Windows.Forms.Label updatesLabel;
    }
}

