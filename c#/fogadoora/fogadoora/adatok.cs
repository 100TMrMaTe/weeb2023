﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fogadoora
{
    internal class adatok
    {
        public string nev;
        public string idopont;
        public DateTime foglalas;
        public adatok(string sor)
        {
            string[] vag=sor.Split(' ');
            nev = vag[0]+" "+vag[1];
            idopont = vag[2];
            foglalas = DateTime.Parse(vag[3].Replace("-"," "));
        }
        public override string ToString()
        {
            return string.Format("tanar neve: {0}\r\nfoglalt idopont: {1}\r\nfoglalas ideje: {2}",nev,idopont,foglalas);



        }
    }
}
