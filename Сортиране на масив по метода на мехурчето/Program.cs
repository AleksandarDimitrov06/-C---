Console.WriteLine("Enter the length of the array");
int length=int.Parse(Console.ReadLine());
double[]array = new double[length];
for(int i=0; i<length; i++)
{
    Console.WriteLine("Enter element number "+(i+1));
    array[i]=double.Parse(Console.ReadLine());
}
Console.WriteLine("Enter how you want to sort your array 'asc'/'desc'");
string sort=Console.ReadLine();
Console.WriteLine("Sorted array");
switch (sort)
{
    case "asc":       
        Console.WriteLine(String.Join(", ",SortAsc(array)));
        break;
    case "desc":
        Console.WriteLine(String.Join(", ",SortDesc(array)));
        break;
    default:
        Console.WriteLine("Incorrect input!");
        Environment.Exit(0);
        break;
}
double[]SortAsc(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                double tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }
    return array;
}
double[] SortDesc(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                double tmp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tmp;
            }
        }
    }
    return array;
}
