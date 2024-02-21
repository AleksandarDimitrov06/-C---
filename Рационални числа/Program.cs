using Рационални_числа;

//опитваме се да прихванем грешка
try
{

    //подканваме потребителя да въведе операция
    Console.WriteLine("Enter operation '+' / '-' / '*' / '/' / 'find rec' or empty line for exit");
    string input = Console.ReadLine();

    //докато не е въвел празен ред
    while (string.IsNullOrEmpty(input))
    {

        //проверяваме каква операция е въвел
        switch (input)
        {

            //събиране
            case "+":

                //подканваме го да въведе първата дроб
                Console.WriteLine("Enter number 1");

                Console.Write("Numerator - ");
                int numerator1 = int.Parse(Console.ReadLine());

                Console.Write("Denominator - ");
                int denominator1 = int.Parse(Console.ReadLine());

                //подканваме го да въведе втората дроб
                Console.WriteLine("Enter number 2");

                Console.Write("Numerator - ");
                int numerator2 = int.Parse(Console.ReadLine());

                Console.Write("Denominator - ");
                int denominator2 = int.Parse(Console.ReadLine());

                //извеждаме резултата
                Console.WriteLine("The result is " + ((new Racional(numerator1, denominator1) + new Racional(numerator2, denominator2))).ToString());
                break;


            //ако е въвел изваждане
            case "-":
                //подканваме го да въведе първата дроб
                Console.WriteLine("Enter number 1");

                Console.Write("Numerator - ");
                numerator1 = int.Parse(Console.ReadLine());

                Console.Write("Denominator - ");
                denominator1 = int.Parse(Console.ReadLine());

                //подканваме го да въведе втората дроб
                Console.WriteLine("Enter number 2");

                Console.Write("Numerator - ");
                numerator2 = int.Parse(Console.ReadLine());

                Console.Write("Denominator - ");
                denominator2 = int.Parse(Console.ReadLine());

                //извеждаме резултата
                Console.WriteLine("The result is " + ((new Racional(numerator1, denominator1) - new Racional(numerator2, denominator2))).ToString());
                break;


            //ако е въвел умножение
            case "*":
                //подканваме го да въведе първата дроб
                Console.WriteLine("Enter number 1");

                Console.Write("Numerator - ");
                numerator1 = int.Parse(Console.ReadLine());

                Console.Write("Denominator - ");
                denominator1 = int.Parse(Console.ReadLine());

                //подканваме го да въведе втората дроб
                Console.WriteLine("Enter number 2");

                Console.Write("Numerator - ");
                numerator2 = int.Parse(Console.ReadLine());

                Console.Write("Denominator - ");
                denominator2 = int.Parse(Console.ReadLine());

                //извеждаме резултата
                Console.WriteLine("The result is " + ((new Racional(numerator1, denominator1) * new Racional(numerator2, denominator2))).ToString());
                break;


            //ако е въвел делене
            case "/":
                //подканваме го да въведе първата дроб
                Console.WriteLine("Enter number 1");

                Console.Write("Numerator - ");
                numerator1 = int.Parse(Console.ReadLine());

                Console.Write("Denominator - ");
                denominator1 = int.Parse(Console.ReadLine());

                //подканваме го да въведе втората дроб
                Console.WriteLine("Enter number 2");

                Console.Write("Numerator - ");
                numerator2 = int.Parse(Console.ReadLine());

                Console.Write("Denominator - ");
                denominator2 = int.Parse(Console.ReadLine());

                //извеждаме резултата
                Console.WriteLine("The result is " + ((new Racional(numerator1, denominator1) / new Racional(numerator2, denominator2))).ToString());
                break;


            //ако е въвел да се намери реципрочна дроб
            case "find rec":

                //подканваме го да въведе дроб
                Console.WriteLine("Enter number");

                //числител
                Console.Write("Numerator - ");
                numerator1 = int.Parse(Console.ReadLine());

                //знаменател
                Console.Write("Denominator - ");
                denominator1 = int.Parse(Console.ReadLine());

                //резултат
                Console.WriteLine("The result is " + (new Racional(numerator1, denominator1)).Reciprocal().ToString());
                break;


            default:
                Console.WriteLine("Wrong input!");
                break;

        }


        //подканваме потребител отново да въведе операция
        Console.WriteLine("Enter operation '+' / '-' / '*' / '/' / 'find rec' or empty line for exit");
        input = Console.ReadLine();
    }
}
catch (Exception)
{
    //ако прихванем грешка съобщаваме на потребителя и излизаме
    Console.WriteLine("Error!");
    Environment.Exit(0);
}
