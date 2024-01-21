Console.WriteLine("Choose operation: '+','-','*','/' OR type Exit");
string input=Console.ReadLine();
while(input != "Exit")
{
    char operation='+';
    switch (input)
    {
        case "+": operation='+'; break;
        case "-":  operation = '-'; break;
        case "*": operation = '*'; break;
        case "/": operation = '/'; break;
        default:Console.WriteLine("Wrong input!");Environment.Exit(0);break;
    }
    Console.WriteLine("Enter first number");
    double n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter second number");
    double n2 = double.Parse(Console.ReadLine());
    switch(operation)
    {
        case '+': Console.WriteLine("The result is "+(n1+n2)); break;
        case '-':Console.WriteLine("The result is " + (n1 - n2));break;
        case '*': Console.WriteLine("The result is " + (n1 * n2)); break;
        case '/': Console.WriteLine("The result is " + (n1 / n2)); break;
    }
    Console.WriteLine("Choose operation: '+','-','*','/' OR type Exit");
    input= Console.ReadLine();
}
Environment.Exit(0);
