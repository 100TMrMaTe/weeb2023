//1.
using System.ComponentModel;

Console.WriteLine("Gyártó: Konyhási Máté");
Console.WriteLine((23+44)/2-20);

//2.
int a = 23;
int b = 44;
int c = 20;
Console.WriteLine("Gyártó: Konyhási Máté");
Console.WriteLine((a + b) / 2 - c);


//3.
static int szamol()
{
    Console.WriteLine("Gyártó: Konyhási Máté");
    return (23 + 44) / 2 - 20; ;
}
Console.WriteLine(szamol());

//4.
int szamol1(int q,int w,int e)
{
    Console.WriteLine("Gyártó: Konyhási Máté");
    return (q + w) / 2 - e;
}
Console.WriteLine(szamol1(23, 44, 20));