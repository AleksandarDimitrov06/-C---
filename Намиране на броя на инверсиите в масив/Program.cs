try
{
    //въвеждаме елементите на масива
    Console.WriteLine("Enter the elements of the array with spaces between them");
    string input = Console.ReadLine();
    int[] array = input.Split(' ').Select(int.Parse).ToArray();

    //променлива за инверсиите
    int inversions = 0;

    //обхождаме масива за всеки елемент
    for (int i = 0; i < array.Length - 1; i++)
    {

        //отново обхождаме масива
        //това обхождане отговаря за намирането на инверсиите
        for (int j = 1; j < array.Length - 1; j++)
        {

            //проверяваме за инверсия
            if (i < j && array[i] > array[j])
                //броя на инвверсиите се увеличава
                inversions++;
        }
    }

    //показваме резултата
    Console.WriteLine("Inversions: " + inversions);
}

catch (Exception)
{

    //ако прихванем грешка излизаме от програмтата
    Console.WriteLine("Wrong input!");
    Environment.Exit(1);
}