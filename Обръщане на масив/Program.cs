List<double> numbers = new List<double>();
Console.WriteLine("Enter number");
string input = Console.ReadLine();
while (!String.IsNullOrEmpty(input))
{
    try
    {
        numbers.Add(double.Parse(input));
    }
    catch (Exception)
    {
        Console.WriteLine("Wrong input!");
    }
    Console.WriteLine("Enter number");
    input = Console.ReadLine();
}
Console.WriteLine("Enter how you want to sort your array ('itr'/'rec')");
switch (Console.ReadLine())
{
    case "itr": ReverseArrayIteratively(numbers); break;
    case "rec":ReverseArrayRecursively(numbers,0,numbers.Count-1);break;  
}
Console.WriteLine("Sorted array");
foreach (double number in numbers)
{
    Console.Write($"{number} ");
}
void ReverseArrayIteratively(List<double> array)
{
    int start = 0;
    int end = array.Count - 1;
    while (start < end)
    { 
        double temp = array[start];
        array[start] = array[end];
        array[end] = temp;
        start++;
        end--;
    }
}

void ReverseArrayRecursively(List<double> array,int start,int end)
{
    if (end <= start) return;
    double a = array[start];
    array[start] = array[end];
    array[end] = a;
    ReverseArrayRecursively(array, start+1, end-1);
}

