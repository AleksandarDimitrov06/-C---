try
{
    int numerator;
    int denominator;

    Console.WriteLine("Enter numerator:");
    numerator = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter denominator:");
    denominator = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter numbers after decimal place:");
    int decimal_place = int.Parse(Console.ReadLine());
    double result=(double)numerator/(double)denominator;
    string formattedNumber = string.Format("{0:F" + decimal_place + "}", result);
    Console.WriteLine($"{formattedNumber}");
}
catch (FormatException)
{
    Console.WriteLine("Wrong format!");
    Environment.Exit(1);
}
