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
            string link = textBox1.Text;
            var command = new Command();
            //string cleanlink = command.CleanLink(link);
            //MessageBox.Show(cleanlink);
            //System.Diagnostics.Process.Start("CMD.exe", "cd domain");
        }
        private void Options_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void filedest_Click(object sender, EventArgs e)
        {
            //click event to trigger DestinationAssign()
            File filedest = new File();
            filedest.DestinationAssign();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //load event to trigger DestNull()
            DestNull();
        }
        private void DestNull()
        {
            //if file destination is null, assign file destination
            File filedest = new File();
            if (filedest.Destination() == null)
            {
                DialogResult result = MessageBox.Show("file Destination not entered");
                if (result == DialogResult.OK)
                {
                    filedest.DestinationAssign();
                }
            }

        }
    }
}
