// See https://aka.ms/new-console-template for more information

string[] hoszusag = { "mm", "cm", "dm", "m", "km" };
int[] hoszusagval = { 10, 10, 10, 1000, 1 };
string[] terulet = { "mm2", "cm2", "dm2", "m2", "km2" };
int[] teruletval = { 100, 100, 100, 1000000, 1 };
string[] ur = { "mm3", "cm3", "dm3", "m3", "km3" };
int[] urval = { 10000, 10000, 10000,1000000000, 1 };

bool jo = false;
string forrasMertek = "";
double szam = 0;
string[] egyseg = { };
int[] valto = { };
while (!jo)
{
    jo = true;
    Console.Write("mit váltsak át PL;12 cm :");
    string be = Console.ReadLine();
    string[] a = be.Split(' ');
    string[] valtoz = { "g", "dkg", "kg" };
    if (a.Length != 2)
    {
        jo = false;
        continue;
    }
    try
    {
        szam = Convert.ToDouble(a[0]);
    }
    catch (Exception)
    {
        Console.WriteLine("nem jo  formatum!");
        jo = false;
        continue;
    }
    Console.WriteLine(szam);
    Console.WriteLine(a[1]);
    if (hoszusag.Contains(a[1]))
    {
        forrasMertek = a[1];
        egyseg = hoszusag;
        valto = hoszusagval;
    }
    else if (terulet.Contains(a[1]))
    {
        forrasMertek = a[1];
        egyseg = terulet;
        valto = teruletval;
    }
    else
    {
        Console.WriteLine("nem jo mertek egyseg");
        jo = false;
        continue;
    }
}
Console.WriteLine("mire valtsam at: ");
for (int i = 0; i < egyseg.Length; i++)
{
    Console.WriteLine(egyseg[i]);
}
string valasz = "";
while (!egyseg.Contains(valasz))
{
    Console.Write("valassz: ");
    valasz = Console.ReadLine();
}
int index1=Array.IndexOf(egyseg, forrasMertek);
int index2=Array.IndexOf(egyseg, valasz);

int szorzo = 1;
double eredmeny = 0;
if (index1 < index2)
{
    for (int i = index1; i < index2; i++)
    {
        szorzo = szorzo * valto[i];
    }
    eredmeny = szam / szorzo;
}
else
{
    for (int i = index2; i < index1; i++)
    {
        szorzo = szorzo * valto[i];
    }
    eredmeny = szam * szorzo;
}
Console.WriteLine("{0} {1} = {2} {3}",szam,forrasMertek,eredmeny,valasz);



    