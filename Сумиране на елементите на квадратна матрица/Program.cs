Console.Write("Enter the size of the matrix: ");
int n = int.Parse(Console.ReadLine());
double[,] matrix = new double[n, n];
Console.WriteLine("Enter the elements of the matrix");
for (int i = 0; i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write($"Element {i}:{j} = ");
        matrix[i, j] = double.Parse(Console.ReadLine());
    }
}
double sumMainDiagonal = 0;
double sumAboveMainDiagonal = 0;
double sumBelowMainDiagonal = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i == j)
        {
            sumMainDiagonal += matrix[i, j];
        }
        else if (i < j)
        {
            sumAboveMainDiagonal += matrix[i, j];
        }
        else
        {
            sumBelowMainDiagonal += matrix[i, j];
        }
    }
}
Console.WriteLine("Sum Main Diagonal = "+sumMainDiagonal);
Console.WriteLine("Sum Above Main Diagonal = " + sumAboveMainDiagonal);
Console.WriteLine("Sum Below Main Diagonal = " + sumBelowMainDiagonal);