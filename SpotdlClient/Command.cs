using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotdlClient
{
    class Command
    {
        private string Link = "";
        public Command()
        {
                
        }
        public Command(string link)
        {
            this.Link = link;
        }

        public string CleanLink(string link)
        {
            //Cleans the link of any trackers
            int index = link.IndexOf('?');
            string cleanlink = link.Substring(0, index);
            return cleanlink;
        }
        //public string CommandConcat()
        //{

        //}

    }
}
