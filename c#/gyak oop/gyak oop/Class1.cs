using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_oop
{
    internal class ember
    {
        public string keresztnev;
        public string vezeteknev;
        public string teljesnev
        {
            get { return vezeteknev+" "+keresztnev; }
        }

        public ember(string vnev, string knev)
        {
            vezeteknev = vnev;
            keresztnev = knev;
        }
    }
}
