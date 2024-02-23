using jaror;
using System.Xml.Linq;

List<adatok> list = new List<adatok>();
StreamReader olvas = new StreamReader("jarmu.txt");

while(!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    list.Add(new adatok(line));

}

olvas.Close();


int min=list[0].ora;
int max = 0; ;



for(int i=0;i<list.Count;i++)
{
    max = list[i].ora;
}
Console.WriteLine((max+1)-min+" legalabb orat dolgoztak aznap");

List<string> orak = new List<string>();
orak.Add(Convert.ToString(list[0].ora) +" óra: "+ list[0].rendszam);

int a = min;
for(int i=0; i<list.Count; i++)
{
    if (list[i].ora>a)
    {
        orak.Add(Convert.ToString(list[i].ora) +" óra: "+ list[i].rendszam);
        a++;

    }
}
for(int i=0; i< orak.Count;i++)
{
    Console.WriteLine(orak[i]);
}


int b = 0;
int k= 0;
int m= 0;


for(int i=0;i<list.Count;i++)
{
    if (list[i].rendszam[0]=='B')
    {
        b++;
    }
    if (list[i].rendszam[0] == 'K')
    {
        k++;
    }
    if (list[i].rendszam[0] == 'M')
    {
        m++;
    }
}
Console.WriteLine("autobuszok szama: "+b);
Console.WriteLine("kamionok szama: "+k);
Console.WriteLine("motorok szama: "+m);

int[] tomb = new int[list.Count];
for(int i=0;i<list.Count;i++)
{
    tomb[i] = (list[i].ora * 3600) + (list[i].perc*60)+list[i].masod;
}

int sor = 0;
int q = 0;

for(int i=0;i<tomb.Length-1;i++)
{
    if (tomb[i + 1] - tomb[i]>q)
    {
        q = tomb[i + 1] - tomb[i];
        sor = i;
    }
}


int ora = tomb[13] / 3600;
int minutes = q / 60;
int seconds = (q-(minutes*60));

for (int i = 1; i < list.Count; i++)
{
    if (i == sor)
    {
        Console.WriteLine(list[i].ora + ":" + list[i].perc + ":" + list[i].masod+" - " + ora+":"+minutes+":"+seconds);
    }
}
