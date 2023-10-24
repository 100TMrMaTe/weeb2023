// See https://aka.ms/new-console-template for more information
Console.Write("kérek egy 9-el oszthato szamot: ");
int szam=Convert.ToInt32(Console.ReadLine());
while(szam%9!=0)
{
    Console.Write("kérek egy 9-el oszthato szamot: ");
    szam = Convert.ToInt32(Console.ReadLine());
}
if(szam%5==0)
{
    Console.WriteLine("oszhato 5-el a "+szam);
}
else
{
    Console.WriteLine("nem oszhato 5-el a "+szam);
}
