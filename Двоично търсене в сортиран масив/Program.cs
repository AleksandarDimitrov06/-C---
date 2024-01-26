Console.WriteLine("Enter array (use spaces between each number) ");
double[]array=Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
int IndexIfFound=0;
if (CheckIfSorted(array))
{
    Console.WriteLine("Enter the number you are searching for");
    double number = double.Parse(Console.ReadLine());
    Console.WriteLine("Choose how to search 'itr'/'rec'");
    string search = Console.ReadLine();
    switch (search)
    {
        case "itr":
            if (BinSearchArrayIteratively(array, number))
                Console.WriteLine("The number is found on position "+IndexIfFound);
            else Console.WriteLine("The number is not found!");
            break;
        case "rec":
            if(BinSearchArrayRecursively(array, number,0,array.Length-1)) Console.WriteLine("The number is found on position "+IndexIfFound);
            else Console.WriteLine("The number is not found!");
            break;
            default: Console.WriteLine("Wrong input");break;
    }
}
else { Console.WriteLine("The array is not sorted!");Environment.Exit(0); }


bool CheckIfSorted(double[] array)
{
    for(int i=0; i<array.Length-1; i++)
    {
        if (array[i] > array[i + 1]) return false;
    }return true;
}
bool BinSearchArrayRecursively(double[] array,double num,int start,int end)
{
    if (end <= start) return false;
    int mid = (start + end) / 2;
    if (num == array[mid])
    {
        IndexIfFound = mid;
        return true;
    }
    else if (num < array[mid])
    {
        return BinSearchArrayRecursively(array, num, start, mid - 1);
    }
    else
    {
        return BinSearchArrayRecursively(array, num, mid + 1, end);

    }
}
bool BinSearchArrayIteratively(double[] array, double num)
{
    int min = 0;
    int max = array.Length - 1;
    while (min <= max)
    {
        int mid = (min + max) / 2;
        if (num == array[mid])
        {
            IndexIfFound = mid;
            return true;
        }
        else if (num < array[mid])
        {
            max = mid - 1;
        }
        else
        {
            min = mid + 1;
        }
    }
    return false;
}
