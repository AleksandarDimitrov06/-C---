Console.WriteLine("How much students you want to add");
int n=int.Parse(Console.ReadLine());
double[][] students =new double[n][];
for(int i=0; i<n; i++)
{
    Console.WriteLine($"Enter the grades for student number {i+1} with spaces between them");
    string input=Console.ReadLine();
    students[i]=input.Split(' ').Select(double.Parse).ToArray();
    foreach (double grade in students[i])
    {
        if (grade < 2 || grade > 6)
        {
            Console.WriteLine("Wrong input!");
            Environment.Exit(0);
        }
    }
}
double[] averagegrades = new double[n];
for(int  j=0; j<n; j++)
{
    double avg = 0;
    for(int i=0; i<students[j].Length; i++)
    {
        avg += students[j][i];
    }
    Console.WriteLine($"Average for student number {j+1} => {Math.Round(avg/students[j].Length,2)}");
    averagegrades[j] = avg / students[j].Length;
}
double averageclass = 0;
foreach(var a in averagegrades)
{
    averageclass += a;
}
Console.WriteLine($"Average for class => {Math.Round(averageclass,2)}");
    


