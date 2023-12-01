// See https://aka.ms/new-console-template for more information

string betuk = "qwertzuiopőúóüöűáélkjhgfdsaíyxcvbnm-";
string szo = "asd";
string gyujto = "";

while (szo!="")
{
    bool jo = true;
    Console.Write("kerek egyszot: ");
    szo = Console.ReadLine();
    


    for (int i = 0; i < szo.Length; i++)
    {
        if (betuk.IndexOf(szo[i]) == -1)
        {
            jo = false;
            Console.WriteLine("ez nemjo szoó!");
            break;
        }
    }
    if (jo)
    {
        gyujto += szo + " ";
    }
}
string[] darabok=gyujto.Trim().Split(' ');

StreamWriter ir = new StreamWriter("szavak.txt"); 
for (int i = 0; i < darabok.Length; i++)
{
    ir.WriteLine(darabok[i]);

}
ir.Close();

