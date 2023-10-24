
string szoveg = "hello bence";
for (int i = 0; i < szoveg.Length; i++)
{
    Console.Write(szoveg[i]);
}

Console.WriteLine();
foreach (char s in szoveg)
{
    Console.Write(s);
}

Console.WriteLine();
for (int i = 0;i < szoveg.Length;i++)
{
    Console.Write(szoveg.Substring(i,1));
}
Console.WriteLine();
Console.WriteLine(szoveg.ToUpper());

string[] drab=szoveg.Split(" ");
Console.WriteLine(drab[0] +" " + drab[1].ToUpper());

Console.WriteLine(szoveg.Substring(0,szoveg.IndexOf(" "))+" "+szoveg.Substring(szoveg.IndexOf(" ")+1).ToUpper());

//kérjetek be egy tobb szobol allo szoveget,es minden szo kezdobetuje legyen nagy a tobbi kicsi