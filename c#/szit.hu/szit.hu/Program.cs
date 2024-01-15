//702
//1
using System.Data;

double[] a = new double[] { 3, 7.12,15.65,-80,50,57 };

double n = 0;
for (int i = 0; i < a.Length; i++)
    {
        if (n < a[i])
        {
            n = a[i];
        }
    }
Console.WriteLine("legnagyobb szam: "+n);

