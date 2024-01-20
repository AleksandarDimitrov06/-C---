Console.WriteLine("Enter number:");
try 
{
    int num=0;
    int input = int.Parse(Console.ReadLine());
    if (input > 0) num = input;
    else {Console.WriteLine("The number must be positive!");Environment.Exit(1);}
    if (Check(num)) Console.WriteLine($"{num} is prime number!");
    else Console.WriteLine($"{num} is not prime number!");
}
catch(FormatException) { Console.WriteLine("Wrong input!");Environment.Exit(1); }
bool Check(int n)
{
    if (n < 2)
        return false;
    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}

