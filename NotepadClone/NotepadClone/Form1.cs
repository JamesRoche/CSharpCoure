using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadClone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // we need to show a file exporer dialog
            var open = new OpenFileDialog();
            open.Filter = "Text Files|*.txt";
            open.ShowDialog();

            var path = open.FileName;
            var filecontent = System.IO.File.ReadAllText(path);
            txtContents.Text = filecontent;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // show a save explorer dialog
            var save = new SaveFileDialog();
            save.ShowDialog();
            var path = save.FileName;
            System.IO.File.WriteAllText(path, txtContents.Text);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }
    }
}
