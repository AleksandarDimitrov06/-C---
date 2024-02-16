try 
{
    //подканваме потребителя да въведе число
    Console.WriteLine("Enter number:");

    //присвояваме входните данни
    int input = int.Parse(Console.ReadLine());

    //променлива, която ще съдържа числото
    int num=0;
    
    //проверяваме дали въведеното от потребителя число е по-голямо от 0

    //ако е по-голямо стойността се прехвърля в num
    if (input > 0) num = input;

    //ако не е по-голямо показваме съобщение и излизаме от програмата
    else 
    {
        Console.WriteLine("The number must be positive!");

        Environment.Exit(1);
    }

    //проверяваме дали числото е просто

    //да
    if (Check(num)) Console.WriteLine($"{num} is prime number!");

    //не
    else Console.WriteLine($"{num} is not prime number!");
}

//ако входните данни не са валидни показваме съобщение на екрана и излизаме от програмата
catch(FormatException) 
{ 
    Console.WriteLine("Wrong input!");
    Environment.Exit(1); 
}

//метод на проверка дали едно число е просто
bool Check(int n)
{

    //проверяваме дали числото е по-голямо от две
    if (n < 2) return false;

    //цикъл, който проверява дали числото може да се дели на числа различни от него и едно
    for (int i = 2; i <= n / 2; i++)
    {
        //ако се дели означава, че числото не е просто
        if (n % i == 0) return false;
    }

    //ако програмата е преминала цикъла значи числото е просто
    return true;
}

