

//1.

Console.Write("kérek egy kisbetut: ");
string a=Console.ReadLine();

string s = "qwertzuioplkjhgfdsayxcvbnm-";
string b=s.ToUpper();

for(int i = 0;i < s.Length;i++)
{
    if (s.IndexOf(a) != -1 && a.Length < 2)
    {
        break;
    }
    else
    {
        Console.Write("adjon meg egy kisbetus karakter!: ");
        a= Console.ReadLine();
    }
}
int c=s.IndexOf(a);
for(int i = 0; i < s.Length;i++)
{
    if(i==c)
    {
        Console.WriteLine(b[i]);
    }
}




//2.

/*
using System.Text.RegularExpressions;
using System.Xml.Linq;

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
*/

//3.
/*
Console.Write("kérek egy kisbetut: ");
char a = Console.ReadKey().KeyChar;
Console.WriteLine();


while (true)
{
    if (char.IsLower(a))
    {
        break;
    }
    else
    {
        Console.WriteLine("not an Uppercase Letter ");
        Console.Write("kérek egy kisbetut: ");
        a = Console.ReadKey().KeyChar;
        Console.WriteLine();
    }
}

Console.WriteLine(a.ToString().ToUpper());
*/