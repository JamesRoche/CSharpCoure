﻿namespace WinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.picExample = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(8, 10);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(51, 20);
            this.lblWelcomeMessage.TabIndex = 1;
            this.lblWelcomeMessage.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(469, 117);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(12, 46);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(469, 26);
            this.txtUserInput.TabIndex = 3;
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // picExample
            // 
            this.picExample.Image = ((System.Drawing.Image)(resources.GetObject("picExample.Image")));
            this.picExample.Location = new System.Drawing.Point(12, 226);
            this.picExample.Name = "picExample";
            this.picExample.Size = new System.Drawing.Size(469, 313);
            this.picExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExample.TabIndex = 4;
            this.picExample.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 551);
            this.Controls.Add(this.picExample);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.PictureBox picExample;
    }
}

