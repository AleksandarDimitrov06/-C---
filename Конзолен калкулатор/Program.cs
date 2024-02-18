//подканваме потребителя да въведе операция
Console.WriteLine("Choose operation: '+','-','*','/' OR type Exit");

//взимаме операцията
string input=Console.ReadLine();

//проверяваме дали иска да излезе
while(input != "Exit")
{
    //по подразбиране нашия оператор ще е събиране
    char operation='+';

    //проверяваме какъв оператор е задал потребителят
    switch (input)
    {

        //ако е плюс
        case "+": operation='+'; break;

        //ако е минус
        case "-":  operation = '-'; break;

        //ако е умножение
        case "*": operation = '*'; break;

        //ако е делене
        case "/": operation = '/'; break;

        //ако е задал невалидни данни излизаме от програмата
        default:Console.WriteLine("Wrong input!");Environment.Exit(0);break;
    }

    //въвеждаме двата операнта
    double n1 = 0;
    double n2 = 0;


    try
    {
        Console.WriteLine("Enter first number");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        n2 = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        //ако са въведени невалидни данни излизаме от програмтата
        Environment.Exit(0);
    }

    //според оператора изчисляваме резултата и го показваме на конзолата
    switch(operation)
    {
        case '+': Console.WriteLine("The result is "+(n1+n2)); break;
        case '-':Console.WriteLine("The result is " + (n1 - n2));break;
        case '*': Console.WriteLine("The result is " + (n1 * n2)); break;
        case '/': Console.WriteLine("The result is " + (n1 / n2)); break;
    }

    //подканваме потребителя отново да въведе оператор
    Console.WriteLine("Choose operation: '+','-','*','/' OR type Exit");
    input= Console.ReadLine();
}

//ако иска да излезе 
Environment.Exit(0);
