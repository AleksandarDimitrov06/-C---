Console.WriteLine("Enter position: ");
int n=int.Parse(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine("The number must be positive!");
    Environment.Exit(0);
}
Console.WriteLine($"The number on position {n} is {Fibonachi(n)}!");
int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;
    else return Fibonachi(n -1) +Fibonachi(n - 2);

}
