try
{

    //въвеждаме дължината на масива
    Console.WriteLine("Enter the length of the array");
    int length = int.Parse(Console.ReadLine());

    //правим масива
    double[] array = new double[length];

    //за всеки елемент задаваме стойност от потребителя
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Enter element number " + (i + 1));
        array[i] = double.Parse(Console.ReadLine());
    }

    //въвеждаме как иска потребителя да подреди масивва
    Console.WriteLine("Enter how you want to sort your array 'asc'/'desc'");
    string sort = Console.ReadLine();

    //според това какво е въвел сортираме числата и ги показваме на конзолата
    Console.WriteLine("Sorted array");
    switch (sort)
    {
        //възходящо
        case "asc":
            Console.WriteLine(String.Join(", ", SortAsc(array)));
            break;

        //низходящо
        case "desc":
            Console.WriteLine(String.Join(", ", SortDesc(array)));
            break;

        //ако е въвел грешни данни излизаме от програмта
        default:
            Console.WriteLine("Incorrect input!");
            Environment.Exit(0);
            break;
    }

}
catch (Exception)
{
    //прихващаме грешка
    Console.WriteLine("Error!");
    Environment.Exit(0);
}


//метод за сортиране възходящо
double[]SortAsc(double[] array)
{

    //обхождаме масива толко пъти, колкото елемента има 
    for (int i = 0; i < array.Length - 1; i++)
    {

        //повторно обхождане, което ще отговаря за размяната на елементите
        for (int j = 0; j < array.Length - 1; j++)
        {

            //ако текущия елемент е по-голям от следващия ги разменяме
            if (array[j] > array[j + 1])
            {
                double tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }

    //връщаме сортирания масив
    return array;
}


//метод за сортиране низходящо
double[] SortDesc(double[] array)
{

    //отново правим два цикъла за обхождане
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {

            //ако текущия елемент е по-малък от следващия ги разменяме
            if (array[j] < array[j + 1])
            {
                double tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }

    //връщаме масива
    return array;
}
