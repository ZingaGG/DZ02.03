int TakeDigit(string a)
{
    System.Console.WriteLine(a);
    int result = Int32.Parse(System.Console.ReadLine());
    return result;
}

double TakeDigitDouble(string a)
{
    System.Console.WriteLine(a);
    double result = Double.Parse(System.Console.ReadLine());
    return result;
}


bool Palindrom(int a)
{
    int lastDigit = a % 10;
    a = a / 10000;
    int firstDigit = a % 10;
    return (lastDigit == firstDigit);
}

double[] ArrayCoord(double[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a[i] = TakeDigitDouble($"Input {i+1} coordinate");
    }
    return a;
}

double DistanceAtoB(double[] a, double[] b)
{
    double result = Math.Sqrt(Math.Pow(b[0]-a[0],2)+Math.Pow(b[1]-a[1],2)+Math.Pow(b[2]-a[2],2));
    return result;
}

// Task 1
/*
Console.WriteLine(Palindrom(TakeDigit("Enter a = ")));
*/
// Task 2

double[] FirstPoint = new double[3];
ArrayCoord(FirstPoint);

double[] SecondPoint = new double[3];
ArrayCoord(SecondPoint);

System.Console.WriteLine("Distance = " + DistanceAtoB(FirstPoint, SecondPoint));

