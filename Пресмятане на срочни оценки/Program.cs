try
{
    //въвеждаме броя на учениците
    Console.WriteLine("How much students you want to add");
    int n = int.Parse(Console.ReadLine());

    //създаваме масив от n-на брой масиви
    double[][] students = new double[n][];

    //обхождаме всички масиви от масива
    for (int i = 0; i < n; i++)
    {
        //подканваме потребителя да въведе оценките на ученика
        Console.WriteLine($"Enter the grades for student number {i + 1} with spaces between them");
        string input = Console.ReadLine();

        //прехвърляме стойностите в основния масив
        students[i] = input.Split(' ').Select(double.Parse).ToArray();

        //ако е въведена оценка, която не отговаря на петобалната система излизаме от програмтата
        foreach (double grade in students[i])
        {
            if (grade < 2 || grade > 6)
            {
                Console.WriteLine("Wrong input!");
                Environment.Exit(0);
            }
        }
    }

    //правим масив, който ще съхранява средните успехи на всички ученици
    double[] averagegrades = new double[n];

    //обхождаме всеки един от учениците
    for (int j = 0; j < n; j++)
    {
        //правим променлива, която ще съхранява сумата от всички оценки на ученика
        double sum = 0;

        //обхождаме всички оценки
        for (int i = 0; i < students[j].Length; i++)
        {
            //добавяме оценката към сумата
            sum += students[j][i];
        }

        //пресмятаме средната оценка на ученика
        averagegrades[j] = sum / students[j].Length;

        //показваме я на конзолата
        Console.WriteLine($"Average for student number {j + 1} => {Math.Round(averagegrades[j], 2)}");
        
    }

    //променлива за средния успех на класа
    double averageclass = 0;

    //обхождаме всички средни оценки
    foreach (var a in averagegrades)
    {

        //добавяме ги към тази за класа
        averageclass += a;
    }

    //показваме я на конзолата
    Console.WriteLine($"Average for class => {Math.Round(averageclass/averagegrades.Length, 2)}");
}
catch (Exception)
{
    Console.WriteLine("Error!");
    Environment.Exit(0);
}
    


