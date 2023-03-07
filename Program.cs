int TakeDigit(string a)
{
    System.Console.WriteLine(a);
    int result = Int32.Parse(System.Console.ReadLine());
    return result;
}

bool Palindrom(int a)
{
    int lastDigit = a % 10;
    a = a / 10000;
    int firstDigit = a % 10;
    return (lastDigit == firstDigit);
}

// Task 1

Console.WriteLine(Palindrom(TakeDigit("Enter a = ")));
