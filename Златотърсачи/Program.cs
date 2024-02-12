using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Xml.Linq;

Console.OutputEncoding=System.Text.Encoding.Unicode;
//Без него не ми се изрисуват елементите на масива


Console.Clear();

//Създаваме две променливи за максималния размер на полето
int max_X = Console.WindowWidth;
int max_Y = Console.WindowHeight;

//създаваме променливи за размерите на полето
int x;
int y;

//проверяваме входните данни
if(!GetFieldBounds(max_X,max_Y,out x,out y))Environment.Exit(0);


//създаваме полето и броя диаманти
int Count_Diamonds;
Elements[,] field = CreateField(x, y, out Count_Diamonds);



//правим променлива за откритите диаманти
int Found_Diamonds=0;


//променлива за изход
bool exit = false;



DrawField(field);


// основен цикъл
while (!exit && Found_Diamonds < Count_Diamonds)
{
    Console.Clear();    
    MoveSomeGuys(field,ref Found_Diamonds);
    ProcessInput(field,ref Found_Diamonds);
    DrawField(field);
    Thread.Sleep(100);
}
Console.WriteLine();
Console.WriteLine($"Found diamonds: {(double)Found_Diamonds / Count_Diamonds * 100}%");




// Създаваме метод, който да проверява зададените от потребителя параметри
bool GetFieldBounds(int max_X,int max_Y,out int x,out int y)
{
    // задаваме първоначални стойности за x и y
    x = 0; y=0;

    //правим си променлива, която да проверява дали зададената стойност отговаря на условията
    bool Check_X = false;

    while (!Check_X)
    {
        //подканваме потребителя да въведе x
        Console.WriteLine($"Enter x (10-{max_X})");

        //проверяваме дали потребилетя е въвел стойност
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return false;

        //проверяваме дали въведените данни са от тип INT
        bool IsTypeInt = int.TryParse(input, out x);

        //ако са от дадения тип проверяваме дали стойността отговаря на параметрите
        if (IsTypeInt)
        {
            if(x>10&&x<max_X)Check_X = true;
        }
    }

    //повтаряме за y
    bool Check_Y = false;

    while (!Check_Y)
    {
        //подканваме потребителя да въведе y
        Console.WriteLine($"Enter y (10-{max_Y})");

        //проверяваме дали потребилетя е въвел стойност
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return false;

        //проверяваме дали въведените данни са от тип INT
        bool IsTypeInt = int.TryParse(input, out y);

        //ако са от дадения тип проверяваме дали стойността отговаря на параметрите
        if (IsTypeInt)
        {
            if (y > 10 && y < max_Y) Check_Y = true;
        }
    }

    //проверяваме дали всичко е успешно
    if(Check_X&&Check_Y)return true;
    else return false;

}





//правим метод за създаване на полето
Elements[,] CreateField(int x,int y,out int Count_diamonds)
{
    //създаваме полето
    Elements[,] field = new Elements[y, x];

    //правим всички полета празни
    for (int i = 0; i < y; i++)
    {
        for (int j = 0; j < x; j++)
        {
            field[i, j] = Elements.None;
        }
    }

    //поставяме нашия човек в начална позиция
    field[0, 0] = Elements.OurGuy;

    //намираме броя на другите хора и диамантите
    int Count_SomeGuy = (int)(x* y * 0.05);
    Count_diamonds = (int)(x * y * 0.10);
    
    //започваме да поставаме елементите в полето

    //Диаманти
    for (int i = 0; i < Count_diamonds; i++)
    {
        bool Found_Empty_Place = false;
        //докато не намери празна позиция сменя числата
        while(!Found_Empty_Place)
        {
            //Намираме случайна позиция, която е празна
            Random r = new Random();
            int Diamond_X = r.Next(x);
            int Diamond_Y = r.Next(y);

            //проверява дали е празна
            if (field[Diamond_Y, Diamond_X] == Elements.None)
            {
                field[Diamond_Y, Diamond_X] = Elements.Diamond;
                Found_Empty_Place=true;
            }
        }
    }

    //Други хора
    for(int i=0;i<Count_SomeGuy;i++)
    {
        //Кодът се повтаря като този за диаманти
        bool Found_Empty_Place = false;

        //докато не намери празна позиция сменя числата
        while (!Found_Empty_Place)
        {
            //Намираме случайна позиция
            Random r = new Random();
            int SomeGuy_X = r.Next(x);
            int SomeGuy_Y = r.Next(y);

            //проверява дали е празна
            if (field[SomeGuy_Y, SomeGuy_X] == Elements.None)
            {
                field[SomeGuy_Y, SomeGuy_X] = Elements.SomeGuy;
                Found_Empty_Place = true;
            }
        }
    }

    //останалите елементи
    for(int i=0;i<y;i++)
    {
        for(int j=0;j<x;j++)
        {

            //проверяваме дали тази позиция е празна и поставяме случаен елемент
            if (field[i, j] == Elements.None)
            {
                Random random = new Random();

                int random_number=random.Next(10);

                if (random_number < 4)//40%
                    field[i, j] = Elements.Ground;

                else if (random_number < 7)//30%
                    field[i, j] = Elements.Grass;

                else if (random_number < 9) //20%
                    field[i, j] = Elements.Tree;

                else //10%
                    field[i, j] = Elements.Stone;
            }
        }
    }
    return field;
    
}





//метод за принтирането на полето
void DrawField(Elements[,] field)
{
    //Взимаме дължината на полето вертикално и хоризонтално 

    Console.CursorVisible = false;


    //започваме обхождането на масива
    for(int i=0;i< field.GetLength(0); i++)
    {

 
        for (int j=0;j<field.GetLength(1); j++)
        {
            //на конзолата принтираме елемента спрямо тази позиция
            switch(field[i, j])
            {

                case Elements.Ground:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("\u2592");
                    break;


                case Elements.Grass:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\u2593");
                    break;


                case Elements.Tree:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\u2663");
                    break;


                case Elements.Stone:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\u0665");
                    break;

                case Elements.OurGuy:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\u263A");
                    break;

                case Elements.SomeGuy:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\u263B");
                    break;

                case Elements.Diamond:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\u2666");
                    break;
            }

        }
        Console.WriteLine();
    }
    //връщаме цвета на текста
    Console.ForegroundColor = ConsoleColor.White;

}





//метод за преместване на героя
bool MoveGuy(Elements[,] field, int x, int y, Directions direction,ref int Found_Diamonds)
{
    //запазваме оригиналните координати
    int originalX = x;
    int originalY = y;

    //проверяваме посоката
    switch (direction)
    {
        case Directions.Left:
            //ако е ляво намаляме x с едно
            x--;

            //проверяваме дали е извън полето
            if (x < 0) return false;

            //проверяваме дали може да преместим героя в тази посока
            switch (field[y, x])
            {
                //ако има земя, трева или диамант можем да преместим героя
                case Elements.Ground:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground; // освобождаваме старата позиция
                    return true;


                case Elements.Grass:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground; 
                    return true;


                case Elements.Diamond:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground;
                    Found_Diamonds++;//увеличаваме броя на намерените диаманти
                    return true;


                default:
                    return false;
            }

        // останалите посоки се обработват по аналогичен начин

        case Directions.Right:
            x++;
            if (x >= field.GetLength(1)) return false;


            switch (field[y, x])
            {
                case Elements.Ground:
                    field[y, x] = field[originalY,originalX];
                    field[originalY, originalX] = Elements.Ground;
                    return true;


                case Elements.Grass:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground;
                    return true;


                case Elements.Diamond:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground;
                    Found_Diamonds++;
                    return true;
                    
                default:
                    return false;
            }

        case Directions.Up:
            y--;
            if (y < 0) return false;
            switch (field[y, x])
            {
                case Elements.Ground:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground;
                    return true;


                case Elements.Grass:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground;
                    return true;


                case Elements.Diamond:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground;
                    Found_Diamonds++;
                    return true;
                default:
                    return false;
            }

        case Directions.Down:
            y++;
            if (y >= field.GetLength(0)) return false;


            switch (field[y, x])
            {
                case Elements.Ground:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground;
                    return true;


                case Elements.Grass:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground;
                    return true;


                case Elements.Diamond:
                    field[y, x] = field[originalY, originalX];
                    field[originalY, originalX] = Elements.Ground;
                    Found_Diamonds++;
                    return true;
                default:
                    return false;
            }

        default:
            return false;
    }
}


//метод за преместването на другите хора
void MoveSomeGuys(Elements[,]field,ref int Found_Diamonds)
{
    //правим цикъл за намирането на всички други хора
    for(int i = 0; i < field.GetLength(0); i++)
    {
        for(int j=0;j<field.GetLength(1); j++)
        {
            //проверяваме дали това е друг човек
            if (field[i,j] == Elements.SomeGuy)
            {
                //ако е го местим в произволна посока
                Random r = new Random();

                int Random_Direction = r.Next(4);

                //нагоре
                if (Random_Direction == 0)
                    
                    MoveGuy(field, j, i, Directions.Up,ref Found_Diamonds);

                //надолу
                else if (Random_Direction==1)
                {
                    MoveGuy(field, j, i, Directions.Down, ref Found_Diamonds);
                }

                //наляво
                else if (Random_Direction == 2)
                {
                    MoveGuy(field, j, i, Directions.Left, ref Found_Diamonds);
                }

                //надясно
                MoveGuy(field, j, i, Directions.Right, ref Found_Diamonds);
            }
        }
    }
   
}


//метод за нашия човек
void MoveOurGuy(Elements[,]field,Directions direction,ref int Found_Diamonds)
{
    //намираме го
    for(int i=0;i<field.GetLength(0);i++)
    {
        for(int j = 0; j < field.GetLength(1); j++)
        {
            if (field[i,j]==Elements.OurGuy)
            {
                //местим го
                MoveGuy(field,j,i,direction, ref Found_Diamonds);
            }
        }
    }
}


//метод, който проверява дали потребителят е натиснал клавиш
bool ProcessInput(Elements[,] field,ref int Found_Diamonds)
{
    //проверяваме дали е натиснал клавиш
    if (!Console.KeyAvailable)
    {
        //ако не е прекратяваме метода
        return false;
    }

    //ако е натиснал клавиш, проверяваме дали е стрелка, изход или друг бутон
    ConsoleKeyInfo info = Console.ReadKey();

    switch(info.Key)
    {
        //ако е натиснал стрелка нагоре местим нашия човек в дадената посока
        case ConsoleKey.UpArrow:
            MoveOurGuy(field,Directions.Up,ref Found_Diamonds); 
            return true;

        //стрелка надолу
        case ConsoleKey.DownArrow:
            MoveOurGuy(field,Directions.Down, ref Found_Diamonds); 
            return true;

        //стрелка наляво
        case ConsoleKey.LeftArrow:
            MoveOurGuy(field, Directions.Left, ref Found_Diamonds);
            return true;

        //надясно
        case ConsoleKey.RightArrow:
            MoveOurGuy(field,Directions.Right, ref Found_Diamonds);
            return true;

        //ако е натиснал escape
        case ConsoleKey.Escape:
            exit = true;
            return true;

        default:
            return true;
    }
}

//правим си списък от елементи
enum Elements
{
    OurGuy,
    SomeGuy,
    Diamond,
    Ground,
    Grass,
    Tree,
    Stone,
    None
}

//списък от посоки
enum Directions
{
    Up,
    Down,
    Left,
    Right
}


    

    

