using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotdlClient
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            //starts py script operation 
            string strCmdText = textBox1.Text;
            var domain = new Command(strCmdText);
            System.Diagnostics.Process.Start("CMD.exe", "cd domain");
        }
        private void Options_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void filedest_Click(object sender, EventArgs e)
        {
            //find a path to be used as download location
            var fbd = new FolderBrowserDialog();
            string folder;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                folder = fbd.SelectedPath;
            }
        }
        //static string Clean(string link)
        //{
        //    char[] linkchar = link.ToCharArray();
        //    for (int i = 0; i < linkchar.Length; i++)
        //    {


        //    }
        //    link = linkchar.ToString();
        //    return link;
        //}
    }
}
