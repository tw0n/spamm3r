﻿namespace WindowsFormsApplication1
{
    partial class FirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTime));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_understand = new System.Windows.Forms.Button();
            this.tutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btn_understand
            // 
            this.btn_understand.Location = new System.Drawing.Point(92, 162);
            this.btn_understand.Name = "btn_understand";
            this.btn_understand.Size = new System.Drawing.Size(186, 23);
            this.btn_understand.TabIndex = 1;
            this.btn_understand.Text = "I Understand!";
            this.btn_understand.UseVisualStyleBackColor = true;
            this.btn_understand.Click += new System.EventHandler(this.btn_understand_Click);
            // 
            // tutLabel
            // 
            this.tutLabel.AutoSize = true;
            this.tutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tutLabel.Location = new System.Drawing.Point(13, 123);
            this.tutLabel.Name = "tutLabel";
            this.tutLabel.Size = new System.Drawing.Size(346, 26);
            this.tutLabel.TabIndex = 2;
            this.tutLabel.Text = "Visit: https://github.com/tw0n/spamm3r/wiki/JangoSMTP-Authorization\r\nfor a full t" +
                "utorial.";
            this.tutLabel.Click += new System.EventHandler(this.tutLabel_Click);
            // 
            // FirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 197);
            this.ControlBox = false;
            this.Controls.Add(this.tutLabel);
            this.Controls.Add(this.btn_understand);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_understand;
        private System.Windows.Forms.Label tutLabel;
    }
}