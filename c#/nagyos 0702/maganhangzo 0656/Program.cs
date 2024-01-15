//702
//1
using System.Data;


Random rand= new Random();
int[] a = new int[7];
for (int i = 0;i<a.Length;i++)
{
    a[i] = rand.Next(1,100);
}

Console.WriteLine(a.Max()+" a legnagyobb szam.");

//2
/*

Random rand = new Random();
int[] a = new int[7];
for (int i = 0; i < a.Length; i++)
{
    a[i] = rand.Next(1, 100);
}

int n = 0;
for (int i = 0; i < a.Length; i++)
{
    if (n < a[i])
    {
        n = a[i];
    }
}
Console.WriteLine(n+" ez a legnagyobb szam.");

*/