using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Business
{
    class Poddcast
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool Played { get; set; }
        public string FilePath { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1}", Title, Description);
        }
    }
}
}
