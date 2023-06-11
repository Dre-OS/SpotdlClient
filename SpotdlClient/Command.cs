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

        public string Clean(string link)
        {
            //Cleans the link of any trackers
            char[] linkchar = link.ToCharArray();
            for (int i = 0; i < linkchar.Length; i++)
            {

            }
            link = linkchar.ToString();
            return link;
        }

    }
}
