Console.WriteLine("Enter a:");
double a=double.Parse(Console.ReadLine());
if (a <= 0)
{
    Console.WriteLine("The coefficient before a must be higher than 0!");
    Environment.Exit(0);
}
Console.WriteLine("Enter b:");
double b = double.Parse(Console.ReadLine());
if (b <= 0)
{
    Console.WriteLine("The coefficient before b must be higher than 0!");
    Environment.Exit(0);
}
Console.WriteLine("Enter c:");
double c = double.Parse(Console.ReadLine());
if (c <= 0)
{
    Console.WriteLine("The coefficient before c must be higher than 0!");
    Environment.Exit(0);
}
double discriminant = b * b - 4 * a * c;
switch (discriminant)
{
    case < 0: Console.WriteLine("Тhere are no roots of the equation");break;
    case 0:
        double result = -b / (2.0 * a);
        Console.WriteLine("There is one root and it is "+result); 
        break;

    default:
        double result1 = (-b + Math.Sqrt(discriminant)) / (2.0 * a);
        double result2 = (-b - Math.Sqrt(discriminant)) / (2.0 * a);
        Console.WriteLine($"The roots of the equation are {result1} and {result2}");
        break;
}
