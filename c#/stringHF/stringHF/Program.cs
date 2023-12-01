// See https://aka.ms/new-console-template for more information
/*
string szoveg = "";
bool vizsga = false;
while (vizsga != true)
{
    Console.Write("Kérek egy több szóból álló szöveget amely szóközzel van elválasztva: ");
    szoveg = Console.ReadLine();
    string[] kell = new string[szoveg.Length];
    kell = szoveg.Split(" ");
    string[] tomb = new string[kell.Length]; ;

    if (kell.Length <= 1)
    {
        Console.WriteLine("Rövid vagy nem szóközzel van elválasztva!");
        Console.WriteLine();
        continue;
    }
    else
    {
        for (int i = 0; i < kell.Length; i++)
        {
            string valtozo = "";
            string elso = "";
            string jo = "";
            valtozo = kell[i];
            elso = valtozo[0].ToString().ToUpper();
            jo = valtozo.Remove(0, 1);
            valtozo = elso + jo;
            tomb[i] = valtozo;
        }
        for (int i = 0; i < tomb.Length; i++)
        {
            Console.Write(tomb[i] + " ");
        }
        Console.WriteLine();
        vizsga = true;
    }
}
*/
//kérj be szot és ellenorizd hogy szo e

Console.Write("Kérek egy szöveget: ");
string szoveg = Console.ReadLine();
string betuk = "qwertzuiopőúóüöűáélkjhgfdsaíyxcvbnm-";
bool a=true;
for (int i = 0; i < betuk.Length; i++)
{
    if (betuk.IndexOf(betuk[i])<0)
    {
        Console.WriteLine("nem szo!");
        a = false;
        break;
    }
}
if (a==true)
{
    Console.WriteLine("{0} jo szó", szoveg);
}

string uj = "";
for(int i = szoveg.Length-1;i>=0;i--)
{
    uj += szoveg[i];
}
Console.WriteLine(uj);

uj = "";
for(int i = 0;i<szoveg.Length ;i++)
{
    uj += szoveg[szoveg.Length-1 - i];
}

Console.WriteLine(uj);


uj = "";

for(int i = 0;0<szoveg.Length ;i+=2)
{
   uj+=szoveg.Substring(szoveg.Length-1-1-i,2);
}
Console.WriteLine(uj);

