using Аритметични_изрази;


//опитваме да прихванем грешка
try
{

    //подканваме потребителя да въведе унарна или бинарна операция
    Console.WriteLine("Choose operation 'Unary'/'Binary'");
    string operation = Console.ReadLine();

    //докато не въведе празен ред
    while (!String.IsNullOrEmpty(operation))
    {

        //проверяваме операцията
        switch (operation)
        {

            //унарна операция
            case "Unary":

                //подканваме потребителя да въведе число
                Console.WriteLine("Enter number");

                //създаваме унарна операция с въведеното от потребителя число
                UnaryOperationExpression Unary = new UnaryOperationExpression(int.Parse(Console.ReadLine()));

                //на конзолата принтираме ToString метода на операцията
                Console.WriteLine(Unary.ToString());
                break;

            //бинарна операция
            case "Binary":

                //подканваме потребителя да въведе пътвото число
                Console.WriteLine("Enter number 1");
                int number1 = int.Parse(Console.ReadLine());

                //въвеждаме операция
                Console.WriteLine("Choose operation '+' / '-' / '*' / '/'");
                char operant = char.Parse(Console.ReadLine());

                //подканваме потребителя да въведе второто число
                Console.WriteLine("Enter number 2");
                int number2 = int.Parse(Console.ReadLine());

                //създаваме бинарна операция с въведените от потребителя данни
                BinaryOperationExpression Binary = new BinaryOperationExpression(number1, number2, operant);
                Console.WriteLine(Binary.ToString());
                break;

            //или потребителя е въвел грешна информация
            default:
                Console.WriteLine("Wrong input");
                break;
        }


        //подканваме потребителя да въведе операция отново
        Console.WriteLine("Choose operation 'Unary'/'Binary'");
        operation = Console.ReadLine();

    }
}
catch (Exception)
{
    //ако прихванем грешка излизаме 
    Console.WriteLine("Error!");
    Environment.Exit(1);
}