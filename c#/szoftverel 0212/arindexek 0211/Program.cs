List<double> szamok = new List<double>
{
    { 838234.328 },
    { 723001.821 },
    { 732400.023 },
    { 832001.100 },
    { 523842.356 },
    { 840000.000 },
    { 345021.100 },
    { 834328.890 },
    { 495000.000 },
    { 834882.100 },
    { 548913.500 },
    { 384882.842 }
};
for(int i = 0; i < szamok.Count; i++)
{
    szamok[i] = Math.Round(szamok[i],2);
}

List<string> s = new List<string>();
string f = "forint";

for (int i = 0;i < szamok.Count;i++)
{
    s.Add(Convert.ToString(szamok[i]));
    while (s[i].Length!=17-f.Length)
    {
        s[i] += " ";
    }
    s[i] += f;
}
for (int i = 0;i<s.Count;i++)
{
    Console.WriteLine(s[i]);
}









