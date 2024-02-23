using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_proba
{
    internal abstract class absztrakt : Interface1
    {
        public int szam()
        {
            return 100000;
        }
        public abstract void kiir();
        int privattusko = 0;
        public int tusko
        {
            get { return privattusko; }
            set { privattusko = value; }
        }
    }
}
