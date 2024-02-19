try
{

    //лист, в който ще се съхраняват числата
    List<double> numbers = new List<double>();

    //подканваме потребителя да въведе число
    Console.WriteLine("Enter number");
    string input = Console.ReadLine();

    //проверяваме дали не е въвел празен низ
    while (!String.IsNullOrEmpty(input))
    {
        try
        {
            //добавяме числото към списъка
            numbers.Add(double.Parse(input));
        }

        catch (Exception)
        {
            //ако прихванем грешка изписваме даденото съобщение
            Console.WriteLine("Wrong input!");
        }


        //подканваме потребителя отново да въведе число
        Console.WriteLine("Enter number");
        input = Console.ReadLine();
    }

    //след като е приключил с въвеждането на числата започваме със сортирането

    //въвеждаме начина на обръщане
    Console.WriteLine("Enter how you want to sort your array ('itr'/'rec')");

    //проверяваме дали е итеративно или рекурсивно
    switch (Console.ReadLine())
    {
        //итеративно
        case "itr": ReverseArrayIteratively(numbers); break;

        //рекурсивно
        case "rec": ReverseArrayRecursively(numbers, 0, numbers.Count - 1); break;
    }



    //извеждаме обърнатия масив
    Console.WriteLine("Reversed array");
    foreach (double number in numbers)
    {
        Console.Write($"{number} ");
    }



}
catch (Exception)
{
    Console.WriteLine("Erro!");
    Environment.Exit(1);
}


//метод за обръщане на масив итеративно
void ReverseArrayIteratively(List<double> array)
{
    //въвеждаме начало
    int start = 0;

    //въвеждаме край, който ще е равен на дължината на масива
    int end = array.Count - 1;

    //докато началото е по-малко от края обръщаме числата
    while (start < end)
    { 

        //променлива, която ще съхранява временно информацията
        double temp = array[start];//объщаме числата
        array[start] = array[end];
        array[end] = temp;

        //увеличаваме началото и съответно намаляме края
        start++;
        end--;
    }
}



//метод за обръщане на масив рекурсивно
void ReverseArrayRecursively(List<double> array,int start,int end)
{

    //краят на рекурсията ще бъде дадената проверка
    if (end <= start) return;


    //разменяме числата
    double a = array[start];
    array[start] = array[end];
    array[end] = a;

    //викаме метода за по-вътрешните числа
    ReverseArrayRecursively(array, start+1, end-1);
}

