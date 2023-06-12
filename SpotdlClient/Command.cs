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
            int i = 0;
            char[] linkchar = link.ToCharArray();
            do
            {
                if (!(linkchar[i].Equals("?")))
                {
                    i++;
                }
            } while (!(linkchar[i].Equals("?")));
            
            link = linkchar.ToString();
            return link;
        }

    }
}
