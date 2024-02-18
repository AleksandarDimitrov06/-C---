try
{
    //подканваме потребителя да въведе коефициент за а
    Console.WriteLine("Enter a:");

    //присвояваме стойността
    double a = double.Parse(Console.ReadLine());

    //това се повтаря за b
    Console.WriteLine("Enter b:");
    double b = double.Parse(Console.ReadLine());

    //както и за c
    Console.WriteLine("Enter c:");
    double c = double.Parse(Console.ReadLine());



    //изчисляваме дискриминантата
    double discriminant = b * b - 4 * a * c;


    //според дискриминантата определяме корените
    switch (discriminant)
    {
        //ако е по-малка от 0 няма корени
        case < 0: Console.WriteLine("Тhere are no roots of the equation"); break;

        //ако е 0 има само един корен
        case 0:

            //намираме корена
            double result = -b / (2.0 * a);

            //показваме го на екрана
            Console.WriteLine("There is one root and it is " + result);
            break;
        //по подразбиране дискриминантата е по-голяма от 0 и има два корена
        default:

            //намираме корените
            double result1 = (-b + Math.Sqrt(discriminant)) / (2.0 * a);
            double result2 = (-b - Math.Sqrt(discriminant)) / (2.0 * a);

            //показваме ги на конзолата
            Console.WriteLine($"The roots of the equation are {result1} and {result2}");
            break;
    }
}
catch (Exception)
{
    //ако потребителят е въвел невалидни данни излизаме от програмата
    Console.WriteLine("Wroong input");
    Environment.Exit(1);
}








