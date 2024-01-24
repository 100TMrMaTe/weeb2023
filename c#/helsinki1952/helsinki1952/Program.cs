using helsinki1952;

List<adatok> eredmeny=new List<adatok>();
StreamReader olvas =new StreamReader("helsinki.txt");

while(!olvas.EndOfStream)
{
    string line = olvas.ReadLine();
    eredmeny.Add(new adatok(line));
}

olvas.Close();

Console.WriteLine("3.feladat:");
Console.WriteLine("pontszerzo helyezesek szama: "+eredmeny.Count);

Console.WriteLine("4.feladat:");
int[] ermekszama = new int[7];
for(int i = 0;i<eredmeny.Count;i++)
{
    ermekszama[eredmeny[i].helyezes]++;
}
Console.WriteLine("arany: " + ermekszama[1]);
Console.WriteLine("ezust: " + ermekszama[2]);
Console.WriteLine("bronz: " + ermekszama[3]);
Console.WriteLine("osszesen: "+(ermekszama[1] + ermekszama[2] + ermekszama[3]));

Console.WriteLine("5. feladat: ");
Console.WriteLine("ossezsen: " + ((ermekszama[1]*7)+ (ermekszama[2] * 5)+ (ermekszama[3] * 4)+ (ermekszama[4] * 3)+ (ermekszama[5] * 2)+ (ermekszama[6] * 1)));
