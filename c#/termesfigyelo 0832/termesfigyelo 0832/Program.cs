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
void betolt2()
{
    string[] tomb = File.ReadAllLines("termes.txt");

    for (int i = 1; i < tomb.Length; i++)
    {
        string[] vag = tomb[i].Split(":");
        id.Add(int.Parse(vag[0]));
        name.Add(vag[1]);
        dulo.Add(vag[2]);
        termes.Add(int.Parse(vag[3]));
        veg.Add(vag[4]);
    }
}

betolt2();


int a = 0;
int mazsa = 0;
for (int i = 0; i < id.Count; i++)
{
    if (name[i] == "búza")
    {
        a++;
        mazsa += termes[i];
    }
}
Console.WriteLine(a+" dülőben volt búza.");
Console.WriteLine("búzából "+mazsa+" mázsa termett");