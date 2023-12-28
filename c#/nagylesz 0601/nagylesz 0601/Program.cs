using System.Text.RegularExpressions;
using System.Xml.Linq;

//1.

Console.Write("kérek egy kisbetut: ");
string w=Console.ReadLine();

string s = "qwertzuioplkjhgfdsayxcvbnmáéűúőóüöí-";
string q=s.ToUpper();

for(int i = 0;i < s.Length;i++)
{
    if (s.IndexOf(w) != -1 && w.Length < 2)
    {
        break;
    }
    else
    {
        Console.Write("adjon meg egy kisbetus karakter!: ");
        w= Console.ReadLine();
    }
}
int c=s.IndexOf(w);

Console.WriteLine(q[c]);





//2.




Console.Write("kérek egy kisbetut: ");
string a =Console.ReadLine();

bool isValid(string str)
{
    return Regex.IsMatch(str, @"[a-z]");
}

while (true)
{
    if (isValid(a) == true && a.Length<2)
    {
        break;
    }
    else
    {
        Console.Write("adjon meg egy kisbetut!: ");
        a = Console.ReadLine();
    }
      
}
a = char.ToUpper(a[0]) + a.Substring(1);
Console.WriteLine(a);


//3.

Console.Write("kérek egy kisbetut: ");
char b = Console.ReadKey().KeyChar;
Console.WriteLine();


while (true)
{
    if (char.IsLower(b))
    {
        break;
    }
    else
    {
        Console.WriteLine("not an Uppercase Letter ");
        Console.Write("kérek egy kisbetut: ");
        b = Console.ReadKey().KeyChar;
        Console.WriteLine();
    }
}

Console.WriteLine(b.ToString().ToUpper());
