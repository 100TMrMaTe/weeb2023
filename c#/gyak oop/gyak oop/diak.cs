using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_oop
{
    internal class diak : udvariasember
    {
        private int kor;
        public diak(string vnev, string knev, int kor) : base(vnev, knev)
        {
            this.kor = kor;
        }
        public void iskola()
        {
            if (kor < 2)
            {
                Console.WriteLine("gurugarara");
            }
            else if (kor < 3) { Console.WriteLine("bolcibe jarkalok"); }
            else if (kor < 7) { Console.WriteLine("ovoda jarok"); }
            else if (kor < 11) { Console.WriteLine("pisis vagyok jarok"); }
            else if (kor < 15) { Console.WriteLine("felso tag jarok"); }
            else if (kor < 20) { Console.WriteLine("technikum jarok"); }
            else if (kor < 25) { Console.WriteLine("okosak iskolaja jarok"); }
            else {Console.WriteLine("felnott uliba jarok"); }
        }
        public void koszonnevvl(diak diakvaltozo)
        {
            Console.WriteLine("csa {0}!",diakvaltozo.keresztnev);
        }
    }
}
