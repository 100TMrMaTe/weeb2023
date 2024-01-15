//1
double b = (3.0 / 4.0) * (3.0 / 4.0);
Console.WriteLine($"{b:F2}");


//2
double a = Math.Pow(3.0 / 4.0, 2);
Console.WriteLine(Math.Round(a, 2));

//3
double fugveny(double a,double b)
{
    return Math.Pow(a / b, 2);
}
Console.WriteLine(Math.Round(fugveny(3, 4),2));
