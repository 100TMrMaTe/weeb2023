using System.Reflection.Emit;
using System.Text;

double[] szamok = { 0.5, 0.8, 1.0, 1.2, 3.0 };

//1
for (int i = 0; i < szamok.Length; i++)
{
    Console.Write("{0,0:0.00} ", szamok[i]);

    int szamok1 = Convert.ToInt32(szamok[i] * 10);
    for (int j = 0; j < szamok1; j++)
    {
        Console.Write("o");
    }

    Console.WriteLine();
}

//2
Console.WriteLine();
for (int i = 0;i < szamok.Length; i++)
{
    Console.Write("{0,0:0.00} ", szamok[i]);
    Console.WriteLine(String.Concat(Enumerable.Repeat("o",Convert.ToInt32(szamok[i] * 10))));
}

Console.WriteLine();
//3
for (int i = 0; i < szamok.Length; i++)
{
    Console.Write("{0,0:0.00} ", szamok[i]);
    int multipler = Convert.ToInt32(szamok[i]*10);
    string TenAs = new string('o', multipler);
    Console.WriteLine(TenAs);
}
Console.WriteLine();
//4
static string Multiply(string a, int b)
{
    StringBuilder s = new StringBuilder(b * a.Length);
    for (int i = 0; i < b; i++)
    {
        s.Append(a);
    }

    return s.ToString();
}


for(int i = 0; i<szamok.Length; i++)
{
    string s = Multiply("o", Convert.ToInt32(szamok[i]*10));
    Console.Write("{0,0:0.00} ", szamok[i]);
    Console.WriteLine(s);
}
//5
Console.WriteLine();

for (int i = 0;i<szamok.Length; i++)
{
    string a = "o";
    int multiplier = Convert.ToInt32(szamok[i] * 10);

    string result = string.Join(a, new string[multiplier + 1]);
    Console.Write("{0,0:0.00} ", szamok[i]);
    Console.WriteLine(result);

}
Console.WriteLine();
//6
static string Repeat(string s, int count)
{
    var a = new System.Text.StringBuilder().Insert(0, s, count).ToString();
    return a;
}
for (int i = 0;i < szamok.Length; i++)
{
    Console.Write("{0,0:0.00} ", szamok[i]);
    Console.WriteLine(Repeat("o", Convert.ToInt32(szamok[i] * 10)));
}
