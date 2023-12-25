//1

List<int> szamok = new List<int>();

Console.Write("1. beszalitas: ");
szamok.Add(Convert.ToInt32(Console.ReadLine()));
Console.Write("2. beszalitas: ");
szamok.Add(Convert.ToInt32(Console.ReadLine()));
Console.Write("3. beszalitas: ");
szamok.Add(Convert.ToInt32(Console.ReadLine()));

for(int i = 0; i < szamok.Count; i++)
{
    while (szamok[i] < 20 || szamok[i] > 150)
    {
        Console.Write((i+1)+". beszalitas: ");
        szamok[i] = Convert.ToInt32(Console.ReadLine());
    }
}

double avg = szamok.Average();
int ossz=szamok.Sum();
Console.WriteLine(Math.Round(avg,2)+"Avg "+ossz+"T");

static List<int> szamok1()
{
    List<int> szamok = new List<int>();

    Console.Write("1. beszalitas: ");
    szamok.Add(Convert.ToInt32(Console.ReadLine()));
    Console.Write("2. beszalitas: ");
    szamok.Add(Convert.ToInt32(Console.ReadLine()));
    Console.Write("3. beszalitas: ");
    szamok.Add(Convert.ToInt32(Console.ReadLine()));

    for (int i = 0; i < szamok.Count; i++)
    {
        while (szamok[i] < 20 || szamok[i] > 150)
        {
            Console.Write((i + 1) + ". beszalitas: ");
            szamok[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return szamok;
}

List<int> szamok2 = szamok1();

int a = 0;
double b = 0.0;
for (int i = 0;i < szamok2.Count;i++)
{
    a+= szamok2[i];
    b+= szamok2[i];
}
b = b/szamok2.Count;

Console.WriteLine(Math.Round(b,2)+"Avg "+a+"T");