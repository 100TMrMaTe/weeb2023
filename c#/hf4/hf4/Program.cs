// See https://aka.ms/new-console-template for more information

/*
Console.Write("kérek egy oldalt: ");
double szam= Convert.ToDouble(Console.ReadLine());

Console.Write("kérek egy oldalt: ");
double szam1 = Convert.ToDouble(Console.ReadLine());


szam = szam * szam;
szam1 = szam1 * szam1;
Console.WriteLine("c= "+Math.Sqrt(szam+szam1));
*/

for(int i=1;i<100;i++)
{
    for (int a = 1; a < 100; a++)
    {
        i = i * i;
        a = a * a;
        double c = Math.Sqrt(i + a);
        if (c%1==0)
        {
            Console.WriteLine("a= "+i);
            Console.WriteLine("b= " + a);
            Console.WriteLine("c= " + c);
        }
    }
}