using System.Text;

Console.Write("a: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("c: ");
int c=Convert.ToInt32(Console.ReadLine());

int kerulet = 0;
while (true) 
{
    if (a + b > c || b + c > a || c + a > b)
    {
        
    }
    else
    {
        Console.WriteLine("nem szerkesztheto haromszog!");
        break;
    }
    kerulet=a+b+c;
    break;
    
}
Console.WriteLine("haromszog kerulete: "+kerulet);
