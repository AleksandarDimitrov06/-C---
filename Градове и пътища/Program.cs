//опитваме се да прихванем грешка
try
{
    //въвеждаме броя на градовете
    Console.WriteLine("Enter number of cities:");
    int n = int.Parse(Console.ReadLine());


    //създаваме масив за градовете
    int[,] cities = new int[n, n];

    //за всеки от градовете правим цикъл
    for (int i = 0; i < n; i++)
    {

        //въвеждаме градовете свързани с дадения 
        Console.WriteLine($"Enter cities connected to city number {i}:");

        //масив, който ще ги съхранява
        string[] connectedCities = Console.ReadLine().Split(' ');

        //обхождаме ги
        foreach (var connectedCity in connectedCities)
        {
            //взимаме индекса на града
            int cityIndex = int.Parse(connectedCity);

            //задаваме стойност в основния масив
            cities[i, cityIndex] = 1;
        }
    }

    //показваме резултатите на конзолата
    Console.WriteLine("Pairs of cities connected through the shortest paths:");
    PrintShortestPaths(FindShortestDistances(cities));


    //декларираме метод за намирането на най-кратките дистанции
    int[,] FindShortestDistances(int[,] cities)
    {
        //взимаме дължината на зададения масив
        int n = cities.GetLength(0);

        //правим квадратна матрица с размерите на зададения масив
        int[,] distances = new int[n, n];

        //прехвърляме стойностите в направената матрица
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                distances[i, j] = cities[i, j];

        //проверяваме най-кратките пътища за всеки град от всеки град
        for (int k = 0; k < n; k++)
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (distances[i, k] != 0 && distances[k, j] != 0 &&
                        (distances[i, j] == 0 || distances[i, j] > distances[i, k] + distances[k, j]))
                        distances[i, j] = distances[i, k] + distances[k, j];


        //връщаме направената матрица
        return distances;
    }
}
catch (Exception) 
{
    //излизаме от конзолатата
    Console.WriteLine("Wrong input!");
    Environment.Exit(1);
}

//метод за извеждането на всички най-кратки пътища
void PrintShortestPaths(int[,] distances)
{
    int n = distances.GetLength(0);
    for (int i = 0; i < n; i++)
        for (int j = i + 1; j < n; j++)
            if (distances[i, j] != 0)
                Console.WriteLine($"{i} - {j}: {distances[i, j]}");
}