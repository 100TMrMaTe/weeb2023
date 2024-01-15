List<int> szamok = new List<int>();

Random r = new Random();
for (int i = 0; i < 500; i++)
{
     int m=r.Next(1000,10000);
    szamok.Add(m);
}

StreamWriter file = new StreamWriter("szamok.csv");

for(int i = 0;i < szamok.Count;i++)
{
    file.WriteLine(szamok[i]);
}

file.Close();
//static int MyMethod(int x, int y)
int paros(List<int> szamok)
{
    int a = 0;
    for(int i = 0;i<szamok.Count;i++)
    {
        if (szamok[i]%2 == 0)
        {
            a++;
        }
    }
    return a;
}

int a=paros(szamok);
Console.WriteLine(a);

//Számoljátok ki és írjátok ki (SZÉPEN, EGÉSZ MONDATBAN!) a páratlan számok összegét! Függvénnyel
int b = 0;
string paratlan(List<int> szamok)
{
    int a = 0;
    int szamoko = 0;
    for (int i = 0; i < szamok.Count; i++)
    {
        if (szamok[i] % 2 != 0)
        {
            a++;
            szamoko += szamok[i];
        }
    }

    string g = "";
    g += a+" ";
    g += szamoko;
    return g;
    
    
    
}

Console.WriteLine(paratlan(szamok));


int v = 0;
for(int i = 0;i<szamok.Count/2;i++)
{
    v += szamok[i];
}
int ma = 0;
for (int i = 249; i < szamok.Count / 2; i++)
{
    ma += szamok[i];
}

if (ma <v)
{
    Console.WriteLine("elso fele nagyobb");
}
else
{
    Console.WriteLine("masodik nagyobb");
}
/*
string egy = "";
int ketto = 0;
int harom = 0;
int negy = 0;
int ot = 0;
int hat = 0;
int het = 0;
int nyo = 0;
int kilenc = 0;

for (int i = 0;i<szamok.Count ; i++)
{
    
    if (szamok[i] /1000==3)
    {
        harom++;
    }
    if (f[0] == 1)
    {
        egy+=1;
    }
    if (f[0] == 2)
    {
        ketto++;
    }
    if (f[0] == 4)
    {
        negy++;
    }
    if (f[0] == 5)
    {
        ot++;
    }
    if (f[0] == 6)
    {
        hat++;
    }
    if (f[0] == 7)
    {
        het++;
    }
    if (f[0] == 8)
    {
        nyo++;
    }
    if (f[0] == 9)
    {
        kilenc++;
    }
}
Console.WriteLine("ennyi harom jegyu van"+harom);
Console.WriteLine("ennyi harom jegyu van" + egy);
Console.WriteLine("ennyi harom jegyu van" + ketto);
Console.WriteLine("ennyi harom jegyu van" + negy);
Console.WriteLine("ennyi harom jegyu van" + ot);
Console.WriteLine("ennyi harom jegyu van" + hat);
Console.WriteLine("ennyi harom jegyu van" + het);
Console.WriteLine("ennyi harom jegyu van" + nyo);
Console.WriteLine("ennyi harom jegyu van" + kilenc);

*/


