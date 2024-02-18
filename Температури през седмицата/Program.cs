try
{
    //правим масив съответно за седем дена и 6 различни часа
    double[,] temperatures = new double[7, 6];

    //обхождаме дните
    for (int i = 0; i < 7; i++)
    {
        Console.WriteLine($"Day number {i + 1}:");

        //обхождаме всеки час от дадения ден
        for (int j = 0; j < 6; j++)
        {
            string hour = "";
            switch (j)
            {
                //0 часа
                case 0:
                    hour = "00:00";
                    break;

                //4 часа
                case 1:
                    hour = "04:00";
                    break;

                //8 часа
                case 2:
                    hour = "08:00";
                    break;

                //12 часа
                case 3:
                    hour = "12:00";
                    break;

                //16 часа
                case 4:
                    hour = "16:00";
                    break;

                //20 часа
                case 5:
                    hour = "20:00";
                    break;
            }

            Console.WriteLine($"{hour} ");

            //взимаме стойността за дадения час
            temperatures[i, j] = double.Parse(Console.ReadLine());
        }
    }



    //суми за всеки ден и всеки час
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

    //обхождаме масива
    for (int i = 0; i < 7; i++)
    {
        for (int j = 0; j < 6; j++)
        {

            //започваме проверка за всеки ден от седмицата

            //понеделник
            if (i == 0) SumMonday += temperatures[i, j];

            //вторник
            else if (i == 1) SumTuesday += temperatures[i, j];

            //сряда
            else if (i == 2) SumWednesday += temperatures[i, j];

            //четвъртък
            else if (i == 3) SumThursday += temperatures[i, j];

            //петък
            else if (j == 4) SumFriday += temperatures[i, j];

            //събота
            else if (i == 5) SumSaturday += temperatures[i, j];

            //неделя
            else SumSunday += temperatures[i, j];



            //сега за всеки час

            //0 часа
            if (j == 0) Sumhour1 += temperatures[i, j];

            //4 часа
            else if (j == 1) Sumhour2 += temperatures[i, j];

            //8 часа
            else if (j == 2) Sumhour3 += temperatures[i, j];

            //12 часа
            else if (j == 3) Sumhour4 += temperatures[i, j];

            //16 часа
            else if (j == 4) Sumhour5 += temperatures[i, j];

            //20 часа
            else Sumhour6 += temperatures[i, j];
        }
    }


    //показваме резултатите на екрана
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
}
catch (Exception)
{
    //ако прихванем грешка излизаме от програмата
    Console.WriteLine("Wrong input");
    Environment.Exit(0);
}
