using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotdlClient
{
    class Domain
    {
        private string Link = "";
        public Domain()
        {
                
        }
        public Domain(string link)
        {
            this.Link = link;
        }

        static Domain Clean(string link)
        {
            char[] linkchar = link.ToCharArray();
            for (int i = 0; i < linkchar.Length; i++)
            {

                
            }
            link = linkchar.ToString();
            return link;
        }

    }
}
