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
            double szam = 1;
            while (szam < 5)
            {
                Console.WriteLine(szam);
                szam += .1;
            }
            char betu = 'a';
            while (betu != 'z') 
            {
                Console.Write(betu+" ");
                betu = (char)(betu + 1);
            }
            Console.WriteLine();
            int kezd = 32;
            while (kezd <= 250)
            {
                Console.Write((char)kezd + " ");
                if(kezd%8==7)
                {
                    Console.WriteLine();
                }
                kezd++;
            }
            Console.WriteLine();
            int szamol = 0;
            for(int i=0; i<16; i++)
            {
                szamol += i;
            }
            Console.WriteLine(szamol);

            for(int i = 0; i >= 100;i++)
            {
                if (i%5==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    return;
                }    
            }
        }   
    }
}
