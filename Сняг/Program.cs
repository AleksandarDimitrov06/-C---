int width, height;
char[,] screen;
int snowSpeed = 1000;
Console.Clear();
width = Console.WindowWidth-1;
height = Console.WindowHeight - 1;
ShowOnlyBottom();
StartSnowfall();
void ShowOnlyBottom()
{
    screen = new char[width, height];
    for (int y = 0; y < height; y++)
    {
        for (int x = 0; x < width; x++)
        {
              if (y == height - 1)
                screen[x, y] = '@';
              else
                screen[x, y] = ' ';
        }
    }
}
void StartSnowfall()
{
    Random rand = new Random();
    bool end = false;
    while (!end)
    {
        for (int x = 0; x < width; x++)
        {
            if (rand.Next(10) < 3)
                screen[x, 0] = '*';
        }
        DrawScreen();
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.UpArrow)
            {
                snowSpeed += 100;
                
            }
            else if (key == ConsoleKey.DownArrow)
            {
                snowSpeed -= 100;
                if (snowSpeed < 0) snowSpeed = 0;
            }
            else end = true;
        }
        Thread.Sleep(snowSpeed);
        for (int y = height - 2; y >= 0; y--)
        {
            for (int x = 0; x < width; x++)
            {
                if (screen[x, y] == '*' && screen[x, y + 1] == ' ')
                {
                    screen[x, y + 1] = '*';
                    screen[x, y] = ' ';
                }
            }
        }
    }
}
void DrawScreen()
{
     Console.SetCursorPosition(0, 0);
     for (int y = 0; y < height; y++)
     {
         for (int x = 0; x < width; x++)
         {
             Console.Write(screen[x, y]);
         }
         Console.WriteLine();
     }
}