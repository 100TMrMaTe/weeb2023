//1
/*
Random rnd = new Random();

int hossz1 = rnd.Next(1,17);
int szel1 = rnd.Next(1, 17);

int hosszf()
{
    Console.Write("kérem hossz poz: ");
    int hossz = Convert.ToInt32(Console.ReadLine());

    
    while (hossz < 1 || hossz > 16)
    {
        Console.WriteLine("hibas hossz 1-16 ig legyen");
        Console.Write("kérem hossz poz: ");
        hossz = Convert.ToInt32(Console.ReadLine());
    }
    
    return hossz;
}
int szelf()
{
    Console.Write("kérem szel poz: ");
    int szel = Convert.ToInt32(Console.ReadLine());
    while (szel < 1 || szel > 16)
    {
        Console.WriteLine("hibas szel 1-16 ig legyen");
        Console.Write("kérem szel poz: ");
        szel = Convert.ToInt32(Console.ReadLine());
    }
    return szel;
}
Console.WriteLine(hossz1);
Console.WriteLine(szel1);
int s = 0;
while (true)
{
    int hossz=hosszf();
    int szel=szelf();
    s += 1;


    
    if (hossz != hossz1)
    {
        int b = Math.Abs(hossz1 - hossz);
        Console.WriteLine("hosszusagra " + b + " tavolsagra van.");
    }
    if (szel != szel1)
    {
        int a = Math.Abs(szel1 - szel);
        Console.WriteLine("szélességbe " + a + " tavolsagra van.");
    }
    
    if(hossz == hossz1&& szel == szel1)
    {
        break;
    }

}
Console.WriteLine(s+" talalgatás volt");
*/
//2
bool checkTipRange(int t)
{
    return t > 0 && t < 17;
}

Random rnd = new Random();

int hossz1 = rnd.Next(1, 17);
int szel1 = rnd.Next(1, 17);


int s = 0;
while (true)
{
    Console.Write("kérem a tippelt pozíciót szóközzel elválasztva: ");
    string? inp = Console.ReadLine();
    Console.WriteLine();

    if (inp == null)
    {
        continue;
    }

    string[] pos = inp.Split(" ");
    if (pos.Length != 2)
    {
        Console.WriteLine("Hibás érték!");
        continue;
    }

    bool error = false;
    int hossz = Convert.ToInt32(pos[0]);
    if (!checkTipRange(hossz))
    {
        Console.WriteLine("A hosszúság értéke érvénytelen, 1 és 16 közötti szám kell legyen!");
        error = true;
    }

    int szel = Convert.ToInt32(pos[1]);
    if (!checkTipRange(szel))
    {
        Console.WriteLine("A szélesség értéke érvénytelen, 1 és 16 közötti szám kell legyen!");
        error = true;
    }

    if (error)
    {
        continue;
    }

    s += 1;

    int a = Math.Abs(hossz1 - hossz);
    int b = Math.Abs(szel1 - szel);

    if (a == 0 && b == 0)
    {
        break;
    }

    Console.WriteLine("hosszusagra " + a + " tavolsagra van.");
    Console.WriteLine("szélességbe " + b + " tavolsagra van.");
}

Console.WriteLine(s + " találgatás volt");