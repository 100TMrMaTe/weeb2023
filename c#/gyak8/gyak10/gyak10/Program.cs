// See https://aka.ms/new-console-template for more information
/*
Console.Write("kérek egy szamot");
int szam=Convert.ToInt32(Console.ReadLine());
string[] szavak = new string[szam];
for (int i=0;i<szavak.Length;i++)
{
    Console.Write("kérek egy szot: ");
    szavak[i] = Console.ReadLine();
}


int sz = 0;
string aszo = "";
foreach(string s in szavak)
{
    if(sz<s.Length)
    {
        sz = s.Length;
        aszo = s;
    }
}
Console.WriteLine(aszo);


string max = "";
for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length > max.Length)
    {
        max = szavak[i];
    }
    
}
Console.WriteLine(max);
int index = 1;
for (int i = 0;i<szavak.Length;i++)
{
    if (szavak[i] == max)
    {
        index = i;
    }
}
Console.WriteLine(index);
*/

/*
string[] szavak= new string[] {"alma","korte","mandarin","ananasz","narancs","banan" };
string[] rovid = new string[szavak.Length];
int rovidindex = 0;
int hosszuindex = 0;

for (int i = 0; i < szavak.Length; i++)
{
    if (szavak[i].Length<=5)
    {
        rovid[rovidindex] = szavak[i];
        rovidindex++;
    }
    else 
    {
        szavak[hosszuindex++] = szavak[i];
    }
}

for (int i = 0; i < rovid.Length; i++)
{
    Console.WriteLine(i);
}
for (int i = 0; i < szavak.Length; i++)
{
    Console.WriteLine(i);
}


int[] tomb=new int[1000];

for (int i=0; i<tomb.Length; i++)
{
    Random rand= new Random();
    int a=Convert.ToInt32(rand.Next(100,999));
    tomb[i]=a;

}
Console.WriteLine(tomb);

int[] tombkeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();
    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb, legnagyobb + 1);
    }

    return tomb;
}

int[] tomb = tombkeszit(1000, 100, 999);

int a = 1;
int b = 1;
for(int i=0;i<tomb.Length;i++)
{
    if (tomb[i]%2==0)
    {
        a += 1;
    }
    else
    {
        b += 1;
    }
}
Console.WriteLine("{0} paros van",a);
Console.WriteLine("{0} paratlan van", b);



int b = 0;
int a = 0;
for (int i = 0; i < tomb.Length; i++)
{
    if (tomb[i] == b)
    { 
        a++; 
    }
    b = tomb[i];
}
Console.WriteLine("{0} egymas melleti azanos szamok ",a);



int b = 1;
int a = 0;
for (int i =1; i < tomb.Length-1; i++)
{
    if (tomb[i] == tomb[i-1])
    {
        a++;
        Console.WriteLine("{0} és {1} {2}={3}",i,i-1,tomb[i-1],tomb[i] );
    }
    b++;
}
Console.WriteLine("{0} egymas melleti azanos szamok ", a);




bool a = false;
for (int i = 1; i < tomb.Length; i++)
{
    if (tomb[i] == tomb[i - 1])
    {
        a=true;
        Console.WriteLine("egxenlo {0}, {1}, {2}", i - 1, i, tomb[i-1], tomb[i]);
    }
}
if(a)
{
    Console.WriteLine("van egyenlo");
}
else
{
    Console.WriteLine("nincs egyenlo");
}

int c = 0;
for (int i = 1; i < tomb.Length; i++)
{
    if (tomb[i] > tomb[i - 1])
    {
        
    }
}
Console.WriteLine("{0} egymas melleti azanos szamok ", a);
*/
/*
void szakasz2(int[] szamtomb)
{
    int kezd = 0;
    int veg = 0;
    int maxkezd = 0;
    int maxveg = 0;

    for(int i=1; i< szamtomb.Length; i++)
    {
        if (szamtomb[i - 1] < szamtomb[i])
        {

        }
        else
        {
            veg = i - 1;
            if(veg-kezd+1>maxveg-maxkezd)
            {
                maxveg = veg;
                maxkezd = kezd;
            }
            kezd = i;
        }
    }
    Console.WriteLine("al legnagyobb novekvo szam sorozat: ",maxveg-maxkezd);
    for (int i=maxkezd;i<maxveg+1;i++)
    {
        Console.Write("{0}, ", szamtomb[i]);
    }
    Console.WriteLine();
}
szakasz2(tomb);

//csinalj egy fugveny ami a legnagyobb csokeno sorozatot adja vissza
void szakasz2(int[] szamtomb)
{
    int kezd = 0;
    int veg = 0;
    int maxkezd = 0;
    int maxveg = 0;

    for (int i = 1; i < szamtomb.Length; i++)
    {
        if (szamtomb[i - 1] < szamtomb[i])
        {

        }
        else
        {
            veg = i - 1;
            if (veg - kezd + 1 > maxveg - maxkezd)
            {
                maxveg = veg;
                maxkezd = kezd;
            }
            kezd = i;
        }
    }
    Console.WriteLine("al legnagyobb novekvo szam sorozat: ", maxveg - maxkezd);
    for (int i = maxkezd; i < maxveg + 1; i++)
    {
        Console.Write("{0}, ", szamtomb[i]);
    }
    Console.WriteLine();
}
szakasz2(tomb);

*/
//készits egy fugvenyt amit vissza 10000 tagu 4 jegyupozitiv szamokat tartalmazo tombot, keresd me ga szakaszokat amik egymastol maximum 10 tavolsagra vannak.

int[] tombkeszit(int darab, int legkisebb, int legnagyobb)
{
    int[] tomb = new int[darab];
    Random rand = new Random();
    for (int i = 0; i < tomb.Length; i++)
    {
        tomb[i] = rand.Next(legkisebb, legnagyobb + 1);
    }

    return tomb;
}
int[] tomb = tombkeszit(10000, 1000, 9999);

for (int i = 1;i<tomb.Length; i++)
{   
    if(tomb[i - 1] - tomb[i] <= 100 && tomb[i - 1] - tomb[i] >= -100 )
    { 
        if(tomb[i] - tomb[i + 1] <= 100 && tomb[i] - tomb[i + 1] >= -100)
        {
            Console.Write(tomb[i - 1] + ", " + tomb[i] + ", " + tomb[i + 1] + "; ");
            Console.WriteLine();
        }
            
    }
    
    
}