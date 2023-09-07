using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            int a;
            a = 2;

            if (a > 2)
            {
                Console.WriteLine("nagyobb");
            }
            else if (a < 2)
            {
                Console.WriteLine("KISEBB");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("paros");
            }
            else
            {
                Console.WriteLine("egyenlo");
            }

            switch (a)
            {
                case 1:
                    Console.WriteLine("egy");
                    break;
                case 2:
                    Console.WriteLine("keto");
                    break;
                case 3:
                    Console.WriteLine("harom");
                    break;
                case 4:
                    Console.WriteLine("negy");
                    break;
                default:
                    Console.WriteLine("valami mas");
                    break;

            }
        }
    }
}
