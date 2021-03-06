﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = "Hello World!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmrTimer.Enabled = !tmrTimer.Enabled;            
            picExample.Image = Image.FromFile(Environment.CurrentDirectory + "//monster2.png");
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            lblWelcomeMessage.Text = DateTime.Now.ToString();
        }
    }
}
