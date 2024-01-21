Console.WriteLine("Enter number or write 'STOP'");
string input=Console.ReadLine();
List<double>numbers=new List<double>();
while (input != "STOP")
{
    double num = double.Parse(input);
    if (num < 2 || num > 6)
    {
        Console.WriteLine("The number must be between 2 and 6!");
        Environment.Exit(0);
    }
    numbers.Add(num);
    Console.WriteLine("Enter number or write 'STOP'");
    input = Console.ReadLine();
}
double sum = 0;
foreach (double num in numbers)
{
    sum+= num;
}
Console.WriteLine($"Average = {sum/numbers.Count}");
