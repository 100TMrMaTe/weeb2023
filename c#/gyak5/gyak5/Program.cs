// See https://aka.ms/new-console-template for more information
Console.Write("kérek egy 1,2 vel oszthato szamot: " );
double szam= Convert.ToDouble(Console.ReadLine());
while(szam%1.2 >0.001)
{
    Console.Write("kérek egy 1,2 vel oszthato szamot: ");
    szam = Convert.ToDouble(Console.ReadLine());
}
for(double i=1;i<szam;i+=1)
{
    if(szam%i==0)
    {
        szam= Convert.ToInt32(szam);
        Console.WriteLine(i);
    }
   
}


for(double i=-10;i<=10;i+=0.1)
{
    Console.WriteLine((i*i+i*3)/9(-5*(i*i));
}
