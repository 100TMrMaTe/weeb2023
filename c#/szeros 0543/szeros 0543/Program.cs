
int a = 200;
//1
for (int i = 0; i <= a ; i++)
{
    if (i % 10== 0)
    {
        Console.Write(i + " ");
    }
}
//2
Console.WriteLine();
for (int i = 0; i <= a; i += 10)
{
    Console.Write(i + " ");
}
Console.WriteLine();
//3
int g = 0;
while(true)
{
    
    if(g<=200&&(g%10==0))
    {
        Console.Write(g + " ");
    }
    g++;
    if (g>200)
    {
        break;
    }
}

