Console.WriteLine("Enter the elements of the array with spaces between them");
string input=Console.ReadLine();
int[]array=input.Split(' ').Select(int.Parse).ToArray();
int min = 100000000;
int max = 0;
double sum = 0;
foreach(var a in array)
{
    if(min>a) min = a;
    if(max<a) max = a;
    sum += a;
}
Console.WriteLine($"The lowest element is {min}");
Console.WriteLine($"The highest element is {max}");
Console.WriteLine($"Average = {sum/array.Length}");
