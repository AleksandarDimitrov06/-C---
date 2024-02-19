//променлива, която ще показва индекса на числото ако е намерено
int IndexIfFound = -1;
try
{

    //подканваме потребителя да въведе масив от числа
    Console.WriteLine("Enter array (use spaces between each number) ");

    //правим масив с дадените числа
    double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

    //проверяваме дали масива е сортиран
    if (CheckIfSorted(array))
    {

        //подканваме потребителя да въведе числото, което търси
        Console.WriteLine("Enter the number you are searching for");
        double number = double.Parse(Console.ReadLine());

        //въвеждаме начина на търсене
        Console.WriteLine("Choose how to search 'itr'/'rec'");
        string search = Console.ReadLine();


        switch (search)
        {
            //ако потребителя е въвел итеративно
            case "itr":
                //викаме метода за итеративно търсене и изкарваме резултата
                if (BinSearchArrayIteratively(array, number))
                    Console.WriteLine("The number is found on position " + IndexIfFound);
                else Console.WriteLine("The number is not found!");
                break;

            //ако е въвел рекурсивно
            case "rec":
                //викаме метода за рекурсивно търсене и изкарваме резултата
                if (BinSearchArrayRecursively(array, number, 0, array.Length - 1)) 
                    Console.WriteLine("The number is found on position " + IndexIfFound);

                else Console.WriteLine("The number is not found!");
                break;


            default: Console.WriteLine("Wrong input"); break;
        }
    }
    //ако не е директно излизаме от програмата
    else { Console.WriteLine("The array is not sorted!"); Environment.Exit(0); }
}
catch (Exception)
{
    //ако програмата прихване грешка изписва съобщение и излиза
    Console.WriteLine("Error!");
    Environment.Exit(0);
}

//метод за проверка дали едни масив е сортиран (възходящо)
bool CheckIfSorted(double[] array)
{

    for(int i=0; i<array.Length-1; i++)
    {
        //ако има елемент, който е по-голям от следващия връща false
        if (array[i] > array[i + 1]) 
            return false;
    }
    //ако не е открило нищо нередно връща true
    return true;
}


//метод за търсене рекурсивно
bool BinSearchArrayRecursively(double[] array,double num,int start,int end)
{
    //край на рекурсията
    if (end <= start) return false;

    //намираме средата
    int mid = (start + end) / 2;

    //ако числото отговаря на средното
    if (num == array[mid])
    {
        
        IndexIfFound = mid;
        return true;
    }

    //ако е по-малко
    else if (num < array[mid])
    {
        //викаме метода като краят става средата минус едно
        return BinSearchArrayRecursively(array, num, start, mid - 1);
    }
    else
    {
        //ако е по-голямо началото става средата минус едно
        return BinSearchArrayRecursively(array, num, mid + 1, end);

    }
}


//търсене на число итеративно
bool BinSearchArrayIteratively(double[] array, double num)
{
    //въвеждаме минимана стойност
    int min = 0;

    //въвеждаме максимална стойност
    int max = array.Length - 1;

    //правим цикъл докато максималната стойност е по-голямта от минималната
    while (min <= max)
    {
        //намираме средния индекс на елемента
        int mid = (min + max) / 2;

        //ако той отговаря на зададеното число връщаме true
        if (num == array[mid])
        {
            IndexIfFound = mid;
            return true;
        }

        //ако е по-голям
        else if (num < array[mid])
        {
            //максималната стойност става разна на средата минус едно
            max = mid - 1;
        }
        else
        {
            //минималната стойност става равна на средата плюс едно
            min = mid + 1;
        }
    }
    //ако не е намерило числото връщаме false
    return false;
}
