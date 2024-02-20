//въвеждаме широчината и дължината на полето
int width = Console.WindowWidth - 1;
int height = Console.WindowHeight - 1;

//създаваме матрицата 
char[,] screen = new char[width, height]; ;

//задаваме скорост на падането на снега от 1 секунда
int snowSpeed = 1000;

//изчистваме конзолата
Console.Clear();

//първоначално показваме само земята
ShowOnlyBottom();

//стартираме падането на снега
StartSnowfall();




//метод за показването на земята
void ShowOnlyBottom()
{
    //обхождаме всички елементи на матрицата
    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
            //проверяваме дали елемента е от най-долната редица
              if (y == height - 1)
                //поставяме дадения символ
                screen[x, y] = '@';


              else
                //ако не е поставяме празен низ
                screen[x, y] = ' ';
        }
    }
}


//метод за започването на снеговалежа
void StartSnowfall()
{
    //променлива от тип рандом
    Random rand = new Random();

    //булева, която ще съхранява дали потребителя е натиснал клавиш
    bool end = false;

    //докато потребителя не е натиснал клавиш
    while (!end)
    {
        //обхождаме първия ред на матрицата
        for (int x = 0; x < width; x++)
        {
            //по случаем избор слагаме снежинка
            if (rand.Next(10) < 3)
                screen[x, 0] = '*';
        }

        //показваме обновеното поле
        DrawScreen();

        //ако потребителя е натиснл клавиш проверяваме дали иска на смени скоростта или да излезе
        if (Console.KeyAvailable)
        {
            //взимаме стойността на натиснатия клавиш
            var key = Console.ReadKey(true).Key;

            //ако е стрелка нагоре
            if (key == ConsoleKey.UpArrow)
            {
                //скоростта се увеличава с 100
                snowSpeed += 100;
                
            }
            //ако е стрелка надолу 
            else if (key == ConsoleKey.DownArrow)
            {
                //скоростта намаля с 100
                snowSpeed -= 100;
                //проверяваме дали няма да стане отрицателна
                if (snowSpeed < 0) snowSpeed = 0;
            }
            //ако не е никой от двата даваме край на снега
            else end = true;
        }

        //изчакваме определената скорост
        Thread.Sleep(snowSpeed);

        //обхождаме матрицата
        for (int y = height - 2; y >= 0; y--)
        {
            for (int x = 0; x < width; x++)
            {
                //проверяваме дали под снежинка има празен низ
                if (screen[x, y] == '*' && screen[x, y + 1] == ' ')
                {
                    //симулираме падането на снежинката
                    screen[x, y + 1] = '*';
                    screen[x, y] = ' ';
                }
            }
        }
    }
}


//метод за визуализирането на полето
void DrawScreen()
{
    //задаваме курсора, за да избегнем премигване на екрана
     Console.SetCursorPosition(0, 0);

    //обхождаме полето
     for (int y = 0; y < height; y++)
     {
         for (int x = 0; x < width; x++)
         {
            //изпечатваме всеки елемент
             Console.Write(screen[x, y]);
         }
         Console.WriteLine();
     }
}