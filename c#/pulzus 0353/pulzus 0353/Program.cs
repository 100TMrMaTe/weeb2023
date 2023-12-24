
Console.Write("életkor: ");
int eletkor = Convert.ToInt32(Console.ReadLine());

Console.Write("nyugalmi pulzus: ");
int nyugp=Convert.ToInt32(Console.ReadLine());

Console.Write("hany % szeretne edzeni: ");
int a=Convert.ToInt32(Console.ReadLine());

int maxp = 220 - eletkor;
int pult = maxp - nyugp;

double ajanlott = pult * (a / 100.0) + nyugp;
Console.WriteLine(Math.Round(ajanlott)+" a pulzus amivel ajánlott edzeni "+a+"% intenzitás mellet.");




