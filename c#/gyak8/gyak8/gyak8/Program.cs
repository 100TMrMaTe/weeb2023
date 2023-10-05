// See https://aka.ms/new-console-template for more information

string[] hoszusag = { "mm", "cm", "dm", "m", "km" };
bool jo = false;
while (!jo)
{
    jo = true;
    Console.Write("mit váltsak át PL;12 cm :");
    string be = Console.ReadLine();
    string[] a = be.Split(' ');
    string[] valtoz = { "g", "dkg", "kg" };
    if (a.Length != 2)
    {
        jo= false;
        continue;
    }
    double szam = 0;
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
    if (hoszusag.Contains(a[1]))
    {
    }
    else
    {
        Console.WriteLine("nem jo mertek egyseg");
        jo = false;
        continue;
    }
    Console.WriteLine("mire valtsam at: ");
    for (int i = 0; i < hoszusag.Length; i++)
    {
        Console.WriteLine(hoszusag[i]);
    }
    Console.Write("valassz: ");
    string valasz=Console.ReadLine();d
}