﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            var result = MessageBox.Show(txtUserInput.Text, "Message box title", MessageBoxButtons.YesNo);
            if(result.ToString() == "Yes")
            {
                MessageBox.Show("thnak you for clicking yes :)");
            }
        }
    }
}
