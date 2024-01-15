using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak_oop
{
    internal class udvariasember : ember
    {
        public udvariasember(string vnev, string knev) : base(vnev, knev)
        {

        }
        public void koszon()
        {
            Console.WriteLine("szia uram! ");
        }
        public void koszon(ember valtozonev)
        {
            Console.WriteLine("szia uram! {0} vagyok",valtozonev.teljesnev);
        }
        public void koszonnev()
        {
            Console.WriteLine(teljesnev);
        }
        public void koszonnev(ember valtozonev)
        {
            Console.WriteLine(valtozonev.teljesnev);
        }
    }
}
