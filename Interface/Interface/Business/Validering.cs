using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Interface.Business
{
    public class Validering
    {
        public bool isChecked { get; set; }

        public bool check_Input(string input)
        {
            if (input == null)
            {
                return false;
                throw (new textBoxNull("heeejo"));               
            }
            else
            {
                return true;
            }
        }
    }

    public class textBoxNull : Exception
    {
        public textBoxNull(string message) : base(message)
        {
        }
    }
}
