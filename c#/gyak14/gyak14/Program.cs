List<string> szavak= new List<string>();

szavak.Add("alma");
szavak.Add("korte");
szavak.Add("barack");
szavak.Add("ananasz");



for (int i = 0; i < szavak.Count; i++)
{
    Console.WriteLine(szavak[i]);
}

foreach(string s in szavak)
{
    Console.WriteLine(s);
}

Console.WriteLine(szavak.Contains("korte"));
Dictionary<string,int> p= new Dictionary<string,int>();

p.Add("laci", 3);
p.Add("bence", 0);
Console.WriteLine(p.Count);