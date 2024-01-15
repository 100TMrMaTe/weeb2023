List<int> szamok = new List<int>();
Random r = new Random();
for (int i = 0; i < 500; i++)
{
    szamok.Add(r.Next(1000,10000));
}

StreamWriter ir = new StreamWriter("szamok.csv");

for (int i = 0;i < szamok.Count;i++)
{
    ir.WriteLine(szamok[i]);
}

ir.Close();


int paros(List<int> szamlista)
{
    int db = 0;
    for (int i = 0;i<szamlista.Count;i++)
    {
        if (szamlista[i]%2 == 0)
        {
            db++;
        }
    }
    return db;
}
Console.WriteLine(paros(szamok));
