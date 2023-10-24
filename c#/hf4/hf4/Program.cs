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

int a = 1;
int b = 1;
double c=Math.Sqrt(a*a+b*b);
for(int i=1;i<50;i++)
{
    for (int k = i; k < 50; k++)
    {
        c = Math.Sqrt(i*i+k*k);
        if (c%1==0)
        {
            Console.WriteLine("{0,5} {1,5} {2,5}",i,k,c);
        }
    }
}
for(int i=1;i<=10;i++)
{
    Console.WriteLine("{0:0.00}",i);
}