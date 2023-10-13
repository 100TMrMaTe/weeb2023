// See https://aka.ms/new-console-template for more information
/*
Console.Write("kérek egy szamot");
int szam=Convert.ToInt32(Console.ReadLine());
string[] szavak = new string[szam];
for (int i=0;i<szavak.Length;i++)
{
    Console.Write("kérek egy szot: ");
    szavak[i] = Console.ReadLine();
}


int sz = 0;
string aszo = "";
foreach(string s in szavak)
{
    if(sz<s.Length)
    {
        sz = s.Length;
        aszo = s;
    }
}
Console.WriteLine(aszo);


string max = "";
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length > max.Length)
    {
        max = szavak[i];
    }
    
}
Console.WriteLine(max);
int index = 1;
for (int i = 0;i<szavak.Length;i++)
{
    if (szavak[i] == max)
    {
        index = i;
    }
}
Console.WriteLine(index);
*/

/*
string[] szavak= new string[] {"alma","korte","mandarin","ananasz","narancs","banan" };
string[] rovid = new string[szavak.Length];
int rovidindex = 0;
int hosszuindex = 0;

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length<=5)
    {
        rovid[rovidindex] = szavak[i];
        rovidindex++;
    }
    else 
    {
        szavak[hosszuindex++] = szavak[i];
    }
}

for (int i = 0; i < rovid.Length; i++)
{
    Console.WriteLine(i);
}
for (int i = 0; i < szavak.Length; i++)
{
    Console.WriteLine(i);
}
*/

int[] tomb=new int[1000];

for (int i=0; i<tomb.Length; i++)
{
    Random rand= new Random();
    int a=Convert.ToInt32(rand.Next(100,999));
    tomb[i]=a;

}
Console.WriteLine(tomb);