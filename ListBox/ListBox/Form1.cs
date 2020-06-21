using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstNames.Enabled = !lstNames.Enabled;
        }

        List<string> names = new List<string>() { "James", "Simon", "Steve", "Connor", "Harry" };
        private void Form1_Load(object sender, EventArgs e)
        {
            lstNames.DataSource = names;
            lstNames.MultiColumn = true;
        }

        private void lstNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentIndex = lstNames.SelectedIndex;
            MessageBox.Show("Hello, " + names[currentIndex]);
        }
    }
}
