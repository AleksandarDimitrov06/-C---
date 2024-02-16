//проверяч на входните данни
bool Check_Input = false;

//променлива за входните данни
string input = null;

//променлива за числото
int num = 0;

while (!Check_Input)
{
    //подканваме потребителя да въведе число
    Console.WriteLine("Enter number:");

    //взимаме входните данни
    input = Console.ReadLine();


    //проверяваме дали входните данни са валидни
    if(int.TryParse(input, out num) && int.Parse(input) >= 0)
    {
        //прекратяваме цикъла
        Check_Input = true;
    }
    
    //в противен случай показваме съобщение за невалидни данни
    else
    {
        Console.WriteLine("The number must be positive!");
        
    }
    
}

//на конзолата принтираме всички прости числа по-малки или равни да зададеното


for (int i = 0; i <= num; i++)
{
    //ако числото е по-малко от две няма резултат
    if(num<2)
    {
        Console.WriteLine("None");

        break;
    }
    
    if (Check(i)) Console.WriteLine($"{i} is prime number!");
}


//метод за намиране на просто число
bool Check(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}