// See https://aka.ms/new-console-template for more information
/*
Console.Write("kérek egy szamot: ");
int szam=Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam2 = Convert.ToInt32(Console.ReadLine());

int x = szam, y=szam1, z = szam2;
Console.WriteLine(Math.Max(Math.Max(x,y) ,z));
*/

/*

int szam3 = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy betut: ");
char betu= Convert.ToChar(Console.ReadLine());
for(int i=0;i<szam3;i++)
{
    Console.Write(betu);
}
*/

/*
Console.Write("kérek egy szamot: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());

int a= (szam*szam)+(szam1*szam1);
Console.WriteLine(a);
*/

/*
Console.Write("kérek egy kisebb szamot mint a kovi szam: ");
int szam = Convert.ToInt32(Console.ReadLine());

Console.Write("kérek egy szamot: ");
int szam1 = Convert.ToInt32(Console.ReadLine());


while(szam>szam1)
{
    Console.Write("kérek egy szamot: ");
    szam = Convert.ToInt32(Console.ReadLine());

    Console.Write("kérek egy szamot: ");
    szam1 = Convert.ToInt32(Console.ReadLine());
}

for(int i=szam;i<szam1;i++)
{
    Console.Write(i * i+"; ");
}
*/

/*
Console.Write("kérek egy szamot: ");
double a = 0;
a=Convert.ToDouble(Console.ReadLine());
Console.Write(Math.Sqrt(a));
*/


for(double i=-10; i<=10; i+=0.1)
{
    Console.WriteLine((((i * i) + (3 * i))) / 9 + (-5 * (i * i)) - 6 * (9 - i) * 2 + 12 + 6 * (1 / ((i * i + 1) * i)) - (12 * i));



}