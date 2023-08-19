using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotdlClient
{
    class File
    {
        public string Folder;
        public File()
        {
            
        }
        public File(string folder)
        {
            this.Folder = folder;
        }
        //return folder
        public string Destination()
        {
            return this.Folder;
        }
        public void DestinationAssign()
        {
            //find a path to be used as download location
            var fbd = new FolderBrowserDialog();
            string folder = "";
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                folder = fbd.SelectedPath;
            }
            this.Folder=folder;
        }
    }
}
