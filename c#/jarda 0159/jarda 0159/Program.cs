//1.

Console.Write("kérem a járda szakasz hosszát: ");
double hossz =Convert.ToDouble(Console.ReadLine());
Console.Write("kérem a járda szakasz szélességét: ");
double szel = Convert.ToDouble(Console.ReadLine());
double mely = 10;

double eredmeny = hossz * szel * mely;
Console.WriteLine("A járdához 10cm mélységben "+eredmeny+"m3 anyag kell.");

Console.WriteLine("szerző: me,myself and I");
Console.WriteLine("készites idopontja: szőr óra bőr perc");
Console.WriteLine("csoport: soha nemis volt.");

//2.

Console.Write("kérem a járda szakasz hosszát: ");
double hossz1 = Convert.ToDouble(Console.ReadLine());
Console.Write("kérem a járda szakasz szélességét: ");
double szel1 = Convert.ToDouble(Console.ReadLine());
Console.Write("kérem a járda szakasz hosszát: ");
double mely1 = Convert.ToDouble(Console.ReadLine());
double szamol(double hossz,double szel,double mely)
{
   return hossz*szel*mely;
}



double eredmeny1=szamol(hossz1,szel1,mely1);
Console.WriteLine("A járdához " + mely1+"cm mélységben " + eredmeny1 + "m3 anyag kell.");
