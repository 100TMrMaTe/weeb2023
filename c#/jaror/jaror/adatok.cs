using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaror
{
    internal class adatok
    {
        public int ora;
        public int perc;
        public int masod;
        public string rendszam;
        public adatok(string sor)
        {
            string[] vag = sor.Split(' ');
            ora = int.Parse(vag[0]);
            perc = int.Parse(vag[1]);
            masod = int.Parse(vag[2]);
            rendszam = vag[3];
        }
    }
}
