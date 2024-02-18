//подканваме потребителя да въведе число
Console.WriteLine("Enter position: ");

//взима стойността на n
int n = 0; 

try
{
    n= int.Parse(Console.ReadLine());
}
//ако е въведел невалидни данни излизаме от програмата
catch(Exception)
{
    Console.WriteLine("Wrong input!");
    Environment.Exit(1);
}

//ако числото е по-малко от нула също излизаме от програмата
if (n < 0)
{
    Console.WriteLine("The number must be positive!");
    Environment.Exit(0);
}

//отпечатваме резултата
Console.WriteLine($"The number on position {n} is {Fibonachi(n)}!");

//метод за намиране число на фибоначи

int Fibonachi(int n)//връща int и има параметър int n
{
    //ако числото е 0 или 1 го връщаме
    if (n == 0 || n == 1) return n;

    //ако е по-голямо от 0 и 1 викаме метода за n-1 събран с същия метод за n-2 (рекурсия)
    else return Fibonachi(n -1) +Fibonachi(n - 2);

}
