Console.WriteLine("Enter number:");
int num=int.Parse(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("The number must be positive!");
    Environment.Exit(0);
}
for(int i = 0; i <= num; i++)
{
    if (Check(i)) Console.WriteLine($"{i} is prime number!");
}
bool Check(int n)
{
    if (n < 2) return false;
    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0) return false;
    }
    return true;
}