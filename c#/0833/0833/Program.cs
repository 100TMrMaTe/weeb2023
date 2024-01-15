


List<int> id = new List<int>();
List<string> name = new List<string>();
List<string> type = new List<string>();
List<string> itemnumber = new List<string>();
List<int> price = new List<int>();
List<string> category = new List<string>();


void betolt2()
{
    string[] tomb = File.ReadAllLines("hangszerek.txt");

    for (int i = 1; i < tomb.Length; i++)
    {
        string[] vag = tomb[i].Split(";");
        id.Add(int.Parse(vag[0]));
        name.Add(vag[1]);
        type.Add(vag[2]);
        itemnumber.Add(vag[3]);
        price.Add(int.Parse(vag[4]));
        category.Add(vag[5]);
    }
}

betolt2();
