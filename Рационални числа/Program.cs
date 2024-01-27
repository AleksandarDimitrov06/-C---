using Рационални_числа;

Console.WriteLine("Enter operation '+' / '-' / '*' / '/' / 'find rec' or empty line for exit");
string input = Console.ReadLine();
while(input != null||input!="")
{ 
switch (input)
{
    case "+":
        Console.WriteLine("Enter number 1");
        Console.Write("Numerator - ");
        int numerator1=int.Parse(Console.ReadLine());
        Console.Write("Denominator - ");
        int denominator1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2");
        Console.Write("Numerator - ");
        int numerator2 = int.Parse(Console.ReadLine());
        Console.Write("Denominator - ");
        int denominator2 = int.Parse(Console.ReadLine());
        Console.WriteLine("The result is " +((new Racional(numerator1, denominator1) + new Racional(numerator2, denominator2))).ToString());
        break;
        case "-":
        Console.WriteLine("Enter number 1");
        Console.Write("Numerator - ");
        numerator1 = int.Parse(Console.ReadLine());
        Console.Write("Denominator - ");
        denominator1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2");
        Console.Write("Numerator - ");
        numerator2 = int.Parse(Console.ReadLine());
        Console.Write("Denominator - ");
        denominator2 = int.Parse(Console.ReadLine());
        Console.WriteLine("The result is " + ((new Racional(numerator1, denominator1) - new Racional(numerator2, denominator2))).ToString());
        break;
    case "*":
        Console.WriteLine("Enter number 1");
        Console.Write("Numerator - ");
        numerator1 = int.Parse(Console.ReadLine());
        Console.Write("Denominator - ");
        denominator1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2");
        Console.Write("Numerator - ");
        numerator2 = int.Parse(Console.ReadLine());
        Console.Write("Denominator - ");
        denominator2 = int.Parse(Console.ReadLine());
        Console.WriteLine("The result is " + ((new Racional(numerator1, denominator1) * new Racional(numerator2, denominator2))).ToString());
        break;
    case "/":
        Console.WriteLine("Enter number 1");
        Console.Write("Numerator - ");
        numerator1 = int.Parse(Console.ReadLine());
        Console.Write("Denominator - ");
        denominator1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2");
        Console.Write("Numerator - ");
        numerator2 = int.Parse(Console.ReadLine());
        Console.Write("Denominator - ");
        denominator2 = int.Parse(Console.ReadLine());
        Console.WriteLine("The result is " + ((new Racional(numerator1, denominator1) / new Racional(numerator2, denominator2))).ToString());
        break;
    case "find rec":
        Console.WriteLine("Enter number 1");
        Console.Write("Numerator - ");
        numerator1 = int.Parse(Console.ReadLine());
        Console.Write("Denominator - ");
        denominator1 = int.Parse(Console.ReadLine());
        Console.WriteLine("The result is " + (new Racional(numerator1,denominator1)).Reciprocal().ToString());
        break;

}
Console.WriteLine("Enter operation '+' / '-' / '*' / '/' / 'find rec' or empty line for exit");
input = Console.ReadLine();
}