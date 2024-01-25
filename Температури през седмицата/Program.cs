double[,] temperatures = new double[7, 6];
for(int i = 0; i < 7; i++)
{
    Console.WriteLine($"Day number {i+1}:");
    for(int j= 0; j < 6; j++)
    {
        string hour = "";
        switch (j)
        {
            case 0:
                hour = "00:00";
                break;
            case 1:
                hour = "04:00";
                break;
            case 2:
                hour = "08:00";
                break;
            case 3:
                hour= "12:00";
                break;
            case 4:
                hour = "16:00";
                break;
            case 5:
                hour = "20:00";
                break;
        }
        Console.WriteLine($"{hour} ");
        temperatures[i,j] = double.Parse(Console.ReadLine());
    }
}
double SumMonday = 0;
double SumTuesday = 0;
double SumWednesday = 0;
double SumThursday = 0;
double SumFriday = 0;
double SumSaturday = 0;
double SumSunday = 0;

double Sumhour1 = 0;
double Sumhour2 = 0;
double Sumhour3 = 0;
double Sumhour4 = 0;
double Sumhour5 = 0;
double Sumhour6 = 0;


for (int i=0;i < 7; i++)
{
    for(int j= 0;j < 6; j++)
    {
        if (i == 0) SumMonday += temperatures[i, j];
        else if (i == 1) SumTuesday += temperatures[i, j];
        else if(i == 2) SumWednesday += temperatures[i, j];
        else if(i == 3) SumThursday += temperatures[i, j];
        else if(j == 4)SumFriday += temperatures[i, j];
        else if(i == 5) SumSaturday += temperatures[i, j];
        else SumSunday += temperatures[i, j];

        if(j==0)Sumhour1 += temperatures[i, j];
        else if(j==1)Sumhour2 += temperatures[i, j];
        else if(j==2)Sumhour3 += temperatures[i, j];
        else if(j==3)Sumhour4 += temperatures[i, j];
        else if(j==4)Sumhour5 += temperatures[i, j];
        else Sumhour6 += temperatures[i, j];
    }
}
Console.WriteLine("Days");
Console.WriteLine($"Monday: {SumMonday}");
Console.WriteLine($"Tuesday: {SumTuesday}");
Console.WriteLine($"Wednesday: {SumWednesday}");
Console.WriteLine($"Thursday: {SumThursday}");
Console.WriteLine($"Friday: {SumFriday}");
Console.WriteLine($"Saturday: {SumSaturday}");
Console.WriteLine($"Sunday: {SumSunday}");
Console.WriteLine("Hours");
Console.WriteLine($"Hour 00:00 = {Sumhour1}");
Console.WriteLine($"Hour 04:00 = {Sumhour2}");
Console.WriteLine($"Hour 08:00 = {Sumhour3}");
Console.WriteLine($"Hour 12:00 = {Sumhour4}");
Console.WriteLine($"Hour 16:00 = {Sumhour5}");
Console.WriteLine($"Hour 20:00 = {Sumhour6}");
