using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("kerek egy szoveget: ");
            string szoveg = Console.ReadLine();
            szoveg = ",";
            while (szoveg != "")
            {
                Console.Write("kerek egy szoveget: ");
                szoveg = Console.ReadLine();
                
            }



            Console.Write("kerek egy szamot: ");
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a szam negyzete"+(szam*szam+1));

            
            Console.Write("kerek egy szamot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int szam2 = 0;
            int szam3 = 0;
            while (szam2 < szam)
            {
                szam3 += 1;
                Console.Write("kerem a "+szam3+". szoveget: ");
                string szoveg = Console.ReadLine();
                Console.WriteLine(szoveg);
                szam2 += 1;
                
            }
            */
            Console.Write("kerek egy szamot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int szam2 = 0;
            int szam3 = 0;
            

            while (int(Last) != szam)
            {
                string szoveg = Console.ReadLine();
                string Last = Convert.ToInt32(szoveg.Substring(szoveg.Length - 1));
                szam3 += 1;
                Console.Write("kerem a  szoveget: ");
                Console.WriteLine(szoveg);
                szam2 += 1;



                {
                {/*
                    int szam = 10;
                    while (szam != 99)
                    {
                        if (szam % 5 == 0)
                        {
                            Console.Write(szam + "  ");
                            szam++;
                        }
                        else
                        {
                            szam++;
                        }
                    }
                    Console.WriteLine();
                    int szam2 = 5;
                    while (szam2 < 95)
                    {
                        szam2 += 5;
                        Console.Write(szam2 + "  ");
                    }
                    Console.WriteLine();
                }*/
                }
            }
        }
    }
}