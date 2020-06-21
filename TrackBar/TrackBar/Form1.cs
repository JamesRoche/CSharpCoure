using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trkValue_Scroll(object sender, EventArgs e)
        {
            lblOutput.Text = trkValue.Value.ToString();
            var items = new List<string>() {  "JAmes", "Steve", "Simon" };
            listBox1.DataSource = items;
            listBox1.MultiColumn = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Text = "derp";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = "123";
            notifyIcon1.ShowBalloonTip(5555);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
