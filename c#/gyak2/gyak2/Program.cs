// See https://aka.ms/new-console-template for more information
using System.Security.Claims;
/*
int i = 10000;
int a = -99999;
if(i<100000)
{
    i += 1;
    if(i%6200==0)
    {
        Console.Write(i + ", ");
    }
}
if (a > -10000)
{
    i += 1;
    if (i % 6200 == 0)
    {
        Console.Write(i + ", ");
    }
}
*/


/*
int a = -99999;
int i = 10000;
while (i >= 10000 && i < 100000)
{
    i += 1;
    if (i % 6200 == 0)
    {
        Console.Write(i+"; ");
    }
}
while (a > -100000 && a <= -10000)
{
    a += 1;
    if (a % 6200 == 0)
    {
        Console.Write(a + "; ");
    }
}
*/
Console.Write("kérek egy 5 jegyu szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());



int f = 0;
int a = 0;
for (int i = -99999; i < -10000; i++)
{
    
    if (i % szam == 0)
    {
        Console.Write(i + "\t");
        a += 1;
        if (a % 8 == 0)
        {
            Console.WriteLine();
        }
    }
    
}
Console.WriteLine();
for (int i=10000; i<100000;i++)
{
    
    if (i % szam == 0)
    {
        Console.Write(i + ";\t");
        f += 1;
        if (f % 8 == 0)
        {
            Console.WriteLine();
        }
    }
    

}
/*
for (int i = 100000; i > 10000; i--)
{
    if (i % 6200 == 0)
    {
        Console.Write(i + "; ");
    }
}
for (int i = -10000; i > -100000; i--)
{
    if (i % 6200 == 0)
    {
        Console.Write(i+"; ");
    }
}
*/


/*
List<int> numbers = new List<int>();
List<int> nam = new List<int>();
for (int i=0;i<2;i++)
{
    Console.Write("kérek egy 3 jegyu szamot: ");
    int szam = Convert.ToInt32(Console.ReadLine());
    while (szam < 100 || szam >= 1000)
    {
        Console.Write("jérek egy 3 jegyu szamot: ");
        szam = Convert.ToInt32(Console.ReadLine());
    }
    for (int a = 1; a < szam; a++)
    {
        if (szam % a == 0)
        {
            numbers.Add(a);
        }
    }
}
Console.WriteLine(String.Join(", ", numbers));
foreach(int i in numbers)
{
    foreach(int a in numbers)
    {
        if(i==a)
        {
            if (nam.All(s => s != i))
            {
                nam.Add(i);
            }
        }
    }
}
Console.WriteLine(String.Join(", ", nam));



while (szam < 100 || szam >= 1000)
{
    Console.Write("jérek egy 3 jegyu szamot: ");
    szam = Convert.ToInt32(Console.ReadLine());
}

for (int i=1; i<szam;i++)
{
    if(szam%i==0)
    {
        numbers.Add(i);
    }
}
Console.WriteLine(String.Join(", ", numbers));
*/

