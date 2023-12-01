// See https://aka.ms/new-console-template for more information
static string szogen(int szavak)
{
    string betuk = "qwertzuiopasdfghjklyxcvbnm-";

    string szo = "";
    var rand = new Random();
    for (int i = 0; i < szavak; i++)
    {
        szo += betuk[rand.Next(betuk.Length)];
    }

    return szo;
}

var rand1 = new Random();
string[] szavak = new string[10000];
for (int i = 0; i < szavak.Length; i++)
{
    szavak[i] = szogen(rand1.Next(4, 7));
}

/*
for(int i = 0;i < szavak.Length;i++)
{
    Console.WriteLine(szavak[i]);
}
*/

File.WriteAllLines("szavak.txt", szavak);

string[] file = File.ReadAllLines("szavak.txt");

string ugyanaz = "";

for (int i = 0; i < file.Length; i++)
{
    for (int j = 0; j < file.Length; j++)
    {
        if (file[i] == file[j] && i < j)
        {
            ugyanaz += file[i] + " ";
        }
    }
}
Console.WriteLine(ugyanaz);

for (int i = 0; i < file.Length; i++)
{
    if (file[i].Length == 4)
    {
        string a = "";
        a = file[i];
        file[i] = char.ToUpper(a[0]) + a.Substring(1);
    }
}

/*
for(int i = 0;i < file.Length;i++)
{
    Console.WriteLine(file[i]);
}
*/


for (int i = 0; i < file.Length; i++)
{
    for (int j = 0; j < file.Length; j++)
    {
        if (file[i].Length == 4 && file[j].Length == 6)
        {
            if (file[j].IndexOf(file[i]) != -1)
            {
                Console.WriteLine(file[i] +", "+ file[j]);
            }
        }
    }
}

for (int i = 0; i < file.Length; i++)
{
    if (file[i].Length == 5)
    {
        file[i] = file[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o", "0");
    }
}


string negy = "";
string ot = "";
string hat = "";
for (int i = 0; i < file.Length; i++)
{
    if (file[i].Length == 4)
    {
        negy += file[i] + " ";
    }
    if (file[i].Length == 5)
    {
        ot += file[i] + " ";
    }
    if (file[i].Length == 6)
    {
        hat += file[i] + " ";
    }
}

string[] negy1 = negy.Trim().Split(" ");
string[] ot1 = ot.Trim().Split(" ");
string[] hat1 = hat.Trim().Split(" ");
Array.Sort(negy1);
Array.Sort(ot1);
Array.Sort(hat1);
File.WriteAllLines("1.txt", negy1);
File.WriteAllLines("2.txt", ot1);
File.WriteAllLines("3.txt", hat1);

