double a=0; 
Console.Write("Enter a: ");
try
{
   a = double.Parse(Console.ReadLine());
}
catch (Exception) 
{ 
    Console.WriteLine("Wrong input!"); 
    Environment.Exit(0);
}
double b=0;
Console.Write("Wrong input: ");
try
{
    b = double.Parse(Console.ReadLine());
}
catch (Exception) 
{ Console.WriteLine("Wrong input");
    Environment.Exit(0);
}
double c=0;
Console.Write("Enter c: ");
try
{
    c = double.Parse(Console.ReadLine());
}
catch (Exception) 
{ 
    Console.WriteLine("Wrong input");
    Environment.Exit(0);
}
double discriminant = b * b - 4 * a * c;
Console.WriteLine($"Discriminant = {discriminant}");