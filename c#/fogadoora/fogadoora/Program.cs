using fogadoora;
List<adatok> foglalasok=new List<adatok>();
StreamReader olvas = new StreamReader("fogado.txt");

while(!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    foglalasok.Add(new adatok(line));
}

olvas.Close();

Console.WriteLine("2.feladat: ");
Console.WriteLine("foglalasok szama: "+foglalasok.Count);

Console.WriteLine("3.feladat: ");
Console.Write("adjon meg egy nevet: ");
string nev=Console.ReadLine();

int a = 0;
for(int i=0;i<foglalasok.Count;i++)
{
    if(foglalasok[i].nev==nev)
    {
        a++;
    }
    
}
if(a!=0)
{
    Console.WriteLine("{0} néven {1} időpontfoglalás van.", nev, a);

}
else
{
    Console.WriteLine("A megadott néven nincs időpontfoglalás");
}
Console.WriteLine("4.feladat: ");
Console.Write("adjon meg egy ervenyes idopontot: ");

string idopont=Console.ReadLine();

List<string> nevek = new List<string>();

for(int i=0; i<foglalasok.Count; i++)
{
    if(idopont==foglalasok[i].idopont)
    {
        nevek.Add(foglalasok[i].nev);
    }
}

nevek.Sort();
for(int i=0;i<nevek.Count;i++)
{
    Console.WriteLine(nevek[i]);
}

File.WriteAllLines(idopont.Replace(":","")+".txt",nevek);

adatok min = foglalasok[0];
for(int i=0;i<foglalasok.Count;i++)
{
    if(foglalasok.Min(f => f.foglalas) == foglalasok[i].foglalas)
        {
        Console.WriteLine("Tanár neve: "+foglalasok[i].nev);
        Console.WriteLine("Foglalt időpont: " + foglalasok[i].idopont);
        Console.WriteLine("Foglalás ideje: " + foglalasok[i].foglalas);
        min= foglalasok[i];
    }
}
Console.WriteLine(min);
Console.WriteLine("6.feladat: ");
