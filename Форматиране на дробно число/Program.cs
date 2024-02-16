try
{
    //променливи за числител и знаменател
    int numerator;
    int denominator;

    //подканваме потребителя да въведе числител
    Console.WriteLine("Enter numerator:");

    //присвояваме стойсността
    numerator = int.Parse(Console.ReadLine());



    //подканваме потребителя да въведе знаменател
    Console.WriteLine("Enter denominator:");

    //присвояваме стойността
    denominator = int.Parse(Console.ReadLine());

    //брой на цифрите след запетаята
    Console.WriteLine("Enter numbers after decimal place:");
    int decimal_place = int.Parse(Console.ReadLine());

    //резултат
    double result=(double)numerator/(double)denominator;

    //правим променлива, която ще съдържа крайния резултат под формата на низ
    string formattedNumber = string.Format("{0:F" + decimal_place + "}", result);

    //показваме го на конзолата
    Console.WriteLine($"{formattedNumber}");
}
catch (FormatException)
{
    Console.WriteLine("Wrong format!");
    Environment.Exit(1);
}
