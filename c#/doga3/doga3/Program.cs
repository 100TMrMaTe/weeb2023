using System.Data;
using System.Reflection.Metadata;

string[] file = File.ReadAllLines("adathalmaz.csv");

List<double> asd = new List<double>();
foreach (string line in file)
{
    var a=line.Trim().Split(";");
    for (int i = 0; i < a.Length; i++)
    {
        asd.Add(i);
    }
}

int m = 0;
for (int i = 6;i<asd.Count;i++)
{
    m++;
}
Console.WriteLine(m/6+"idöpont volt.");



double l = 100.12;
for (int i = 6; i < asd.Count; i++)
{

    if (asd[i] < l)
    {
        l ==  asd[i];
    }
}
Console.WriteLine(l/(m/6));




List<double> asd1 = new List<double>();
int g = 0;
for (int i = 1;i< asd.Count;i++)
{
    g++;
    if(g%6==0)
    {
        asd1.Add(asd[i]);
    }
}
int h = 100;
for(int i=0;i< asd1.Count;i++)
{
    if(asd1[i]<h)
    {
        _ = h == asd1[i];
    }
}

var a = 0;
for (int i = 0; i < asd1.Count; i++)
{
    a += asd1[i];
}
Console.WriteLine(a/asd1.Count);




List<double> asd2 = new List<double>();
int k = 0;
for (int i = 2; i < asd.Count; i++)
{
    k++;
    if (k % 6 == 0)
    {
        asd1.Add(asd[i]);
    }
}
int j = 100;
for (int i = 0; i < asd2.Count; i++)
{
    if (asd2[i] < j)
    {
        _ = j == asd2[i];
    }
}

var b = 0;
for (int i = 0; i < asd2.Count; i++)
{
    b += asd2[i];
}
Console.WriteLine(b / asd2.Count);




List<double> asd3 = new List<double>();
int p = 0;
for (int i = 1; i < asd.Count; i++)
{
    p++;
    if (p % 6 == 0)
    {
        asd1.Add(asd[i]);
    }
}
int v = 100;
for (int i = 0; i < asd3.Count; i++)
{
    if (asd3[i] < v)
    {
        _ = v == asd3[i];
    }
}

var q = 0;
for (int i = 0; i < asd3.Count; i++)
{
    q += asd3[i];
}
Console.WriteLine(q / asd3.Count);






List<double> asd4 = new List<double>();
int r = 0;
for (int i = 1; i < asd.Count; i++)
{
    r++;
    if (r % 6 == 0)
    {
        asd4.Add(Convert.ToDouble(asd[i]));
    }
}
double n = 100;
for (int i = 0; i < asd4.Count; i++)
{
    if (asd4[i] < n)
    {
        _ = n == asd4[i];
    }
}

var x = 0;
for (int i = 0; i < asd4.Count; i++)
{
    x += asd4[i];
}
Console.WriteLine(x / asd1.Count);