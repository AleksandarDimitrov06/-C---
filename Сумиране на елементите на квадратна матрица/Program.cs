try
{
    //въвеждаме размера на матрицата
    Console.Write("Enter the size of the matrix: ");
    int n = int.Parse(Console.ReadLine());

    //създаваме матрицата с дадения размер
    double[,] matrix = new double[n, n];

    //подканваме потребителя да въведе стойност за всеки елемент на матрицата
    Console.WriteLine("Enter the elements of the matrix");
    for (int i = 0; i < n; i++)//обхождане вертикално
    {
        for (int j = 0; j < n; j++)//обхождане хоризонтално
        {
            Console.Write($"Element {i}:{j} = ");
            matrix[i, j] = double.Parse(Console.ReadLine());
        }
    }

    //въвеждаме необходимите променливи за различните сума на елементите
    double sumMainDiagonal = 0;
    double sumAboveMainDiagonal = 0;
    double sumBelowMainDiagonal = 0;

    //за всеки елемент проверяваме къде се намира и го добавяме към съответната сума
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

    //показваме резултатите на екрана
    Console.WriteLine("Sum Main Diagonal = " + sumMainDiagonal);
    Console.WriteLine("Sum Above Main Diagonal = " + sumAboveMainDiagonal);
    Console.WriteLine("Sum Below Main Diagonal = " + sumBelowMainDiagonal);
}
catch (Exception)
{
    Console.WriteLine("Wrong input!");
    Environment.Exit(1);
}