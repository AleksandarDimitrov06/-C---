//опитваме се да прихванем някаква грешка
try
{
    //подканваме потребителя да въведе числата на масива
    Console.WriteLine("Enter the elements of the array with spaces between them");
    string input = Console.ReadLine();

    //правим масив от числата разделени чрез празен низ
    int[] array = input.Split(' ').Select(int.Parse).ToArray();

    //въвеждаме най-голям и най-малък елемент на масива
    int min = 100000000;
    int max = 0;

    //въвеждаме сума
    double sum = 0;

    //обхождаме масива
    foreach (var a in array)
    {
        //проверяваме дали елемента е по-малък от текущия най-малък такъв
        if (min > a)  //ако е той става най-малък 
            min = a;

        //проверяваме дали елемента е по-гоялм от най-големия
        if (max < a)  //ако е той става най-голям 
            max = a;

        //прибавяме елемента към сумата
        sum += a;
    }

    //показваме резултата на екрата
    Console.WriteLine($"The lowest element is {min}");
    Console.WriteLine($"The highest element is {max}");
    Console.WriteLine($"Average = {sum / array.Length}");
}
catch (Exception)
{
    //ако програмата прихване грешка излизаме от нея
    Console.WriteLine("Wrong input!");
    Environment.Exit(1);
}
