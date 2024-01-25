Console.WriteLine("Enter number of cities:");
int n = int.Parse(Console.ReadLine());

int[,] cities = new int[n,n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter cities connected to city number {i}:");
    string[] connectedCities = Console.ReadLine().Split(' ');
    foreach (var connectedCity in connectedCities)
    {
        int cityIndex = int.Parse(connectedCity);
        cities[i, cityIndex] = 1;
    }
}

Console.WriteLine("Pairs of cities connected through the shortest paths:");
PrintShortestPaths(FindShortestDistances(cities));
int[,] FindShortestDistances(int[,] cities)
{
    int n = cities.GetLength(0);
    int[,] distances = new int[n, n];

    for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
            distances[i, j] = cities[i, j];

    for (int k = 0; k < n; k++)
        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (distances[i, k] != 0 && distances[k, j] != 0 &&
                    (distances[i, j] == 0 || distances[i, j] > distances[i, k] + distances[k, j]))
                    distances[i, j] = distances[i, k] + distances[k, j];

    return distances;
}
void PrintShortestPaths(int[,] distances)
{
    int n = distances.GetLength(0);
    for (int i = 0; i < n; i++)
        for (int j = i + 1; j < n; j++)
            if (distances[i, j] != 0)
                Console.WriteLine($"{i} - {j}: {distances[i, j]}");
}