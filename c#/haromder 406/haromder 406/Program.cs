using System.Text;
Console.WriteLine("Konyhási Máté")
Console.WriteLine("A harom oldal bekérése utan a program eldonti szerkesztheto e  a haromszog ha igen vissza tér a haromszog keruletevel")
Console.Write("kérem háromszög a oldalat: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("kérem háromszög b oldalat: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("kérem háromszög c oldalat: ");
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
