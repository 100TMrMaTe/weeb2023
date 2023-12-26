
using System;
using System.Text.RegularExpressions;

List<int> id = new List<int>();
List<string> name = new List<string>();
List<string> dulo = new List<string>();
List<int> termes = new List<int>();
List<string> veg = new List<string>();

void betolt()
{
    StreamReader olvas = new StreamReader("termes.txt");
    olvas.ReadLine();
    while (!olvas.EndOfStream)
    {
        string sor = olvas.ReadLine();
        string[] vag = sor.Split(":");
        id.Add(int.Parse(vag[0]));
        name.Add(vag[1]);
        dulo.Add(vag[2]);
        termes.Add(int.Parse(vag[3]));
        veg.Add(vag[4]);
    }

    olvas.Close();
}
betolt();

int dulok()
{
    int a = 0;
    for (int i = 0; i < id.Count; i++)
    {
        if (name[i] == "repce")
        {
            a++;
        }
    }
    return a;
}
int mazsak()
{
    int mazsa = 0;
    for (int i = 0; i < id.Count; i++)
    {
        if (name[i] == "repce")
        {
            mazsa+=termes[i];
        }
    }
    return mazsa;
}
Console.WriteLine(dulok()+" duloben volt repce termesztve.");
Console.WriteLine("repceből " + mazsak() + " mázsa termett");

