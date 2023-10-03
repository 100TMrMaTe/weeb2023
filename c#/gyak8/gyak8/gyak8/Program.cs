// See https://aka.ms/new-console-template for more information


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
        continue;
    }
    Console.WriteLine(szam);
}