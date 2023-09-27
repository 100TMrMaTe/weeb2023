// See https://aka.ms/new-console-template for more information
/*
Console.Write("kérek egy szamot: ");
int szam= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(szam);
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(szam-szam1);
*/

/*
Console.Write("kérek egy szamot: ");
double szam = Convert.ToDouble(Console.ReadLine());

Console.Write("kérek egy szamot: ");
double szam1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(szam*szam1);
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Max(szam,szam1));
*/

/*
Console.Write("kérek egy szamot: ");
double szam = Convert.ToDouble(Console.ReadLine());

Console.Write("kérek egy szamot: ");
double szam1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(szam+" / "+szam1+" = "+(szam/szam1));
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

for (int i = Math.Min(szam, szam1)+1; i < Math.Max(szam, szam1); i++)
{
    Console.WriteLine(i);
}
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

for (int i = Math.Min(szam, szam1); i <= Math.Max(szam, szam1); i++)
{
    Console.WriteLine(i);
}
*/

/*
int szam0 = 0;

Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

for (int i = Math.Min(szam, szam1) + 1; i < Math.Max(szam, szam1); i++)
{
    szam0 += 1;
    Console.Write(i*i+" ");
    if (szam0 % 2 == 0)
    {
        Console.WriteLine();
    }
    
}
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam2 = Convert.ToInt32(Console.ReadLine());

int szam0= Math.Max(szam, szam1);
Console.WriteLine(Math.Max(szam0,szam2));
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

for (int i = Math.Min(szam, szam1) + 1; i < Math.Max(szam, szam1); i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

for (int i = Math.Min(szam, szam1) + 1; i < Math.Max(szam, szam1); i++)
{
    if (i % 5 == 0)
    {
        Console.WriteLine(i);
    }
}
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

while (szam >= 100)
{
    Console.Write("kérek egy szamot: ");
    szam = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(szam);
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

while (szam < 100 || szam>=1000)
{
    Console.Write("kérek egy szamot: ");
    szam = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(szam);
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

while (szam >= 100 || szam<=-100)
{
    Console.Write("kérek egy szamot: ");
    szam = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(szam);
*/