﻿using System.Xml;

static string szo(int darab)
{
    Random rand = new Random();
    string betuk = "qwertzuiopőúöüóűáélkjhgfdsaíyxcvbnm";
    string magan = "aeuio";
    string masal = "qwrtzplkjhgfdsyxcvbnm";

    string szo = "";
    for (int i = 0; i < darab; i++)
    {
        //int index = rand.Next(betuk.Length);
        //szo += betuk[index];
        if(i%2==0)
        {
            int index = rand.Next(magan.Length);
            szo += magan[index];
        }
        else
        {
            int index = rand.Next(masal.Length);
            szo += masal[index];
        }
    }

    return szo;
}

string[] sokSzo = new string[10000];
Random rand = new Random();
for (int i = 0; i < sokSzo.Length; i++)
{
    sokSzo[i] = szo(rand.Next(2, 11));
}




File.WriteAllLines("szavak.txt", sokSzo);
/*
for (int i = 0; i<sokSzo.Length; i++)
{
    Console.WriteLine(sokSzo[i]);
}
*/
sokSzo[sokSzo.Length - 1] = "aa";
sokSzo[0] = "dcddkssasss";

string[] szavak = File.ReadAllLines("szavak.txt");

string tobbszoros = "";
for (int i = 0; i < szavak.Length; i++)
{
    for (int k = i + 1; k < szavak.Length; k++)
    {
        if (szavak[i] == szavak[k])
        {
            tobbszoros += ";" + szavak[k];
            break;
        }
    }
}
if(tobbszoros !="")
{
    tobbszoros = tobbszoros.Substring(1);
    Console.WriteLine("Többször előforduló szavak: " + tobbszoros);
}


//Az összes 4 betűs első betűje legyen nagy!
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length == 4)
    {
        szavak[i] = szavak[i].Substring(0, 1).ToUpper() + szavak[i].Substring(1);
        Console.WriteLine(szavak[i]);
    }
}

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length == 4)
    {
        for (int k = 0; k < szavak.Length; k++)
        {
            if (szavak[k].Length == 6)
            {
                if (szavak[k].IndexOf(szavak[i].ToLower()) > -1)
                {
                    Console.WriteLine("{0} benne van ebben: {1}", szavak[i], szavak[k]);
                }
            }
        }
    }
}

for(int i = 0;i<szavak.Length;i++)
{
    if (szavak[i].Length==5)
    {
        szavak[i] = szavak[i].Replace("a", "@").Replace("e", "3").Replace("l", "1").Replace("o", "0");
    }
}


string[] valogat=new string[11];
for (int i = 0;i< szavak.Length;i++)
{
    valogat[szavak[i].Length] += szavak[i] + ",";
}


for(int j = 2;j<valogat.Length;j++)
{
    string[] darabolt = valogat[j].Substring(0, valogat[j].Length - 2).Split(",");
    Array.Sort(darabolt);
    File.WriteAllLines(j+"betus.txt", darabolt);
}
