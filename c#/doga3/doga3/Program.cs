
List<int>percek=new List<int>();
List<double> homerok1 = new List<double>();
List<double> homerok2 = new List<double>();
List<double> homerok3 = new List<double>();
List<double> homerok4= new List<double>();
List<int> darab = new List<int>();


void betolt()
{
    StreamReader olvas = new StreamReader("adathalmaz.csv");
    olvas.ReadLine();

    while(olvas.EndOfStream)
    {
        string line = olvas.ReadLine();
        string[] vag = line.Split(";");
        percek.Add(int.Parse(vag[0]));
        homerok1.Add(double.Parse(vag[1]));
        homerok2.Add(double.Parse(vag[2]));
        homerok3.Add(double.Parse(vag[3]));
        homerok4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
    Console.WriteLine(darab[0]);


    olvas.Close();
}

void betolt2()
{
    string[] tomb = File.ReadAllLines("adathalmaz.csv");

    for(int i = 1; i < tomb.Length; i++)
    {
        string[] vag = tomb[i].Split(";");
        percek.Add(int.Parse(vag[0]));
        homerok1.Add(double.Parse(vag[1]));
        homerok2.Add(double.Parse(vag[2]));
        homerok3.Add(double.Parse(vag[3]));
        homerok4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
}

void betolt3()
{
    string[] tomb = File.ReadAllLines("adathalmaz.csv");

    foreach(string sor in )
    {
        string[] vag = tomb[i].Split(";");
        percek.Add(int.Parse(vag[0]));
        homerok1.Add(double.Parse(vag[1]));
        homerok2.Add(double.Parse(vag[2]));
        homerok3.Add(double.Parse(vag[3]));
        homerok4.Add(double.Parse(vag[4]));
        darab.Add(int.Parse(vag[5]));
    }
}