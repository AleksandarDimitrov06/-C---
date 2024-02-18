//опитваме се да прихванем някаква грешка
using System.Diagnostics.CodeAnalysis;

try
{

    //подканваме потребитетя да въведе число за успех или да прекрати програмтат
    Console.WriteLine("Enter number or write 'STOP'");

    //взимаме входните данни
    string input = Console.ReadLine();

    //правим лист от double, който ще съхранява всички успехи
    List<double> numbers = new List<double>();

    //проверяваме дали потребителя е задал край на програмата
    while (input != "STOP")
    {
        //взимаме стойността на входните данни
        double num = double.Parse(input);

        //ако е въвел число, което не отговаря на условията прекратяваме програмтата
        if (num < 2 || num > 6)
        {
            Console.WriteLine("The number must be between 2 and 6!");
            Environment.Exit(0);
        }

        //добавяме успеха към успехите
        numbers.Add(num);

        //подканваме потребителя отново да въведе информация
        Console.WriteLine("Enter number or write 'STOP'");
        input = Console.ReadLine();
    }

    //когато програмта излезе от цикъла изчисляваме общата сума от всички успехи
    //променива, която ще съхранява резултата
    double sum = 0;

    //цикъл за обхождане на всички успехи
    foreach (double num in numbers)
    {

        //прибавяме успеха към сумата
        sum += num;
    }

    //показваме средния успех на екрана
    Console.WriteLine($"Average = {sum / numbers.Count}");
}
catch (Exception)
{
    //ако сме прихванали някаква грешка спираме програмта
    Console.WriteLine("Wrong input!");
    Environment.Exit(0);
}
