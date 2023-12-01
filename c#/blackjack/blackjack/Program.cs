using System.Collections.Generic;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Dictionary<string, int> ertekek = new Dictionary<string, int>()
{
    { "2", 2 },
    { "3", 3 },
    { "4", 4 },
    { "5", 5 },
    { "6", 6 },
    { "7", 7 },
    { "8", 8 },
    { "9", 9 },
    { "10", 10 },
    { "J", 10 },
    { "Q", 10 },
    { "K", 10 },
    { "A", 11 }
};

List<Dictionary<string, string>> olap = new List<Dictionary<string, string>>();

string[] lapok = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
string[] symbol = new string[] { "♠", "♣", "♦", "♥" };

for (int i = 0; i < lapok.Length; i++)
{
    for (int j = 0; j < symbol.Length; j++)
    {
        Dictionary<string, string> card = new Dictionary<string, string>() {
            { "number", lapok[i] },
            { "symbol", symbol[j] }
        };
        olap.Add(card);
    }
}

static string jatekkartyak(List<Dictionary<string, string>> Pack, bool elsolap)
{
    string s = "";
    for (int i = 0; i < Pack.Count; ++i)
    {
        if (s.Length > 0)
        {
            s += " ";
        }

        if (i == 0 && !elsolap)
        {
            s += "*";
        }
        else
        {
            s += Pack[i]["number"] + Pack[i]["symbol"];
        }
    }
    return s;
}

static int opack(List<Dictionary<string, string>> Pack, bool used, Dictionary<string, int> ertekek)
{
    int sum = 0;
    for (int i = 0; i < Pack.Count; ++i)
    {
        if (i == 0 && !used)
        {
            continue;
        }

        sum += ertekek[Pack[i]["number"]];
    }
    return sum;
}

static void vissza(List<Dictionary<string, string>> playerPack, List<Dictionary<string, string>> dealerPack, bool Dealer1, Dictionary<string, int> ertekek)
{
    Console.WriteLine("Játékos lapjai: " + jatekkartyak(playerPack, true));
    Console.WriteLine("Játékos lapjainak értéke: " + opack(playerPack, true, ertekek));
    Console.WriteLine("Osztó lapjai: " + jatekkartyak(dealerPack, Dealer1));
    Console.WriteLine("Osztó lapjainak értéke: " + opack(dealerPack, Dealer1, ertekek));
    Console.WriteLine();
}

static bool over21(List<Dictionary<string, string>> playerPack, List<Dictionary<string, string>> dealerPack, Dictionary<string, int> ertekek)
{
    int playerSzam = opack(playerPack, true, ertekek);
    if (playerSzam > 21)
    {
        Console.WriteLine("Loser!");
        Console.WriteLine();
        return true;
    }

    int dealerSzam = opack(dealerPack, true, ertekek);
    if (dealerSzam > 21)
    {
        Console.WriteLine("Winner!");
        Console.WriteLine();
        return true;
    }

    return false;
}

while (true)
{
    Console.WriteLine("Nyomj ENTER-t, ha játszani szeretnél!");
    string Menu = Console.ReadLine();
    if (Menu.Length > 0)
    {
        break;
    }

    // lapok keverése
    List<int> hasznalt = new List<int>();
    List<Dictionary<string, string>> random = new List<Dictionary<string, string>>();
    Random rand = new Random();
    for (int i = 0; i < olap.Count; i++)
    {
        while (true)
        {
            int r = rand.Next(olap.Count);
            if (hasznalt.IndexOf(r) == -1)
            {
                random.Add(olap[r]);
                hasznalt.Add(r);
                break;
            }
        }
    }

    List<Dictionary<string, string>> playerPack = new List<Dictionary<string, string>>();
    List<Dictionary<string, string>> dealerPack = new List<Dictionary<string, string>>();

    playerPack.Add(random[0]);
    random.RemoveAt(0);

    dealerPack.Add(random[0]);
    random.RemoveAt(0);

    // Játékos húz
    playerPack.Add(random[0]);
    random.RemoveAt(0);

    // Osztó húz
    dealerPack.Add(random[0]);
    random.RemoveAt(0);


    // játékos húzásai
    while (true)
    {
        int playerossz = opack(playerPack, true, ertekek);

        vissza(playerPack, dealerPack, playerossz > 21, ertekek);

        if (playerossz > 20)
        {
            break;
        }

        Console.WriteLine("Ha lapot kérsz nyomj ENTER-t, ha megállsz írd be hogy stand és nyomj ENTER-t.");
        string be = Console.ReadLine();
        Console.WriteLine();
        if (be == "stand")
        {
            break;
        }

        playerPack.Add(random[0]);
        random.RemoveAt(0);
    }

    if (over21(playerPack, dealerPack, ertekek))
    {
        continue;
    }

    // osztó húzásai
    while (true)
    {
        int dealerossz = opack(dealerPack, true, ertekek);
        if (dealerossz >= 17)
        {
            break;
        }

        dealerPack.Add(random[0]);
        random.RemoveAt(0);
    }

    vissza(playerPack, dealerPack, true, ertekek);
    if (over21(playerPack, dealerPack, ertekek))
    {
        continue;
    }

    int ps = opack(playerPack, true, ertekek);
    int ds = opack(dealerPack, true, ertekek);
    if (ps == ds)
    {
        Console.WriteLine("Push!");
    }
    else if (ps > ds)
    {
        Console.WriteLine("Winner!");
    }
    else
    {
        Console.WriteLine("Loser!");
    }

    Console.WriteLine();
    Console.WriteLine();
}
