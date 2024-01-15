int fugveny()
{
    Console.Write("kerek egy szamot: ");
    int a=Convert.ToInt32(Console.ReadLine());

    Console.Write("kerek egy szamot: ");
    int b = Convert.ToInt32(Console.ReadLine());

    return a + b;
}
Console.WriteLine( fugveny());

int fugveny1()
{
    Console.Write("kerek egy szamot: ");
    int a=int.Parse(Console.ReadLine());

    Console.Write("kerek egy szamot: ");
    int b = int.Parse(Console.ReadLine());

    return b + a;
}
Console.WriteLine(fugveny1());

int fugveny2()
{
    Console.Write("kerek egy szamot: ");
    int a=Int32.Parse(Console.ReadLine());

    Console.Write("kerek egy szamot: ");
    int b = Int32.Parse(Console.ReadLine());

    return a + b;
}
Console.WriteLine(fugveny2());

int fugveny3()
{
    int[] a=new int[2];
    Console.Write("kerek egy szamot: ");
    a[0] = Convert.ToInt32(Console.ReadLine());

    Console.Write("kerek egy szamot: ");
    a[1] = Convert.ToInt32(Console.ReadLine());

    return a.Sum();


}
Console.WriteLine(fugveny3());

int fugveny4()
{

    int[] a = new int[2];
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write("kerek egy szamot: ");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    return a.Sum();
}

Console.WriteLine(fugveny4());

int fugveny5()
{
    List<int> a = new List<int>();
    for (int i = 0; i < 2; i++)
    {
        Console.Write("kerek egy szamot: ");
        a.Add(Convert.ToInt32(Console.ReadLine()));
    }
    return a.Sum();
}
Console.WriteLine(fugveny5());