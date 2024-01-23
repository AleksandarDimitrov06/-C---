Console.WriteLine("Enter the elements of the array with spaces between them");
string input=Console.ReadLine();
int[] array = input.Split(' ').Select(int.Parse).ToArray();
int inversions = 0;
for (int i = 0; i < array.Length-1; i++)
{
    for(int j=1; j < array.Length-1; j++)
    {
        if (i < j && array[i] > array[j])inversions++;
    }
}
Console.WriteLine("Inversions: "+inversions);