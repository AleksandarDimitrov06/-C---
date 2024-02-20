//пробваме да прихванем някаква грешка
try
{
    //въвеждаме x
    Console.WriteLine("Enter x");
    int x = int.Parse(Console.ReadLine());

    //въвеждаме y
    Console.WriteLine("Enter y");
    int y = int.Parse(Console.ReadLine());

    //създаваме лабиринта
    Items[,] maze = GenerateMaze(y, x);

    //показваме го на екрана
    ShowMaze(maze);

    //опитваме се да намерим пътя към изхода
    if (FindMazePath(maze, 0, 0)) 
        //ако успеем
        Console.WriteLine("You reached the end!");

    //ако не успеем
    else Console.WriteLine("The end is not found!");
}
catch (Exception)
{
    //ако прихванем грешка изписваме на конзолата и излизаме от програмата
    Console.WriteLine("Wrong input!");
    Environment.Exit(1);
}



//метод за създаване на лабиринт
Items[,] GenerateMaze(int x,int y)
{
    //променлива от тип рандом
    Random r=new Random();

    //създаваме матрица с посочените размери
    Items[,] maze = new Items[x, y];

    //обхождаме всеки елелент на матрицата
    for(int i = 0; i < x; i++)
    {
        for(int j=0; j < y; j++)
        {
            //по случаен избор създавваме лабиринта
            int num=r.Next(0,100);

            if (num % 5 == 0)
            {
                maze[i, j] = Items.Wall;
            }
            else maze[i,j] = Items.Path;
        }
    }

    //първия елемент винаги ще бъде празен, за да може това да е началото
    maze[0, 0] = Items.Path;

    //последния елемент ще е края
    maze[x-1, y-1] = Items.End; 

    //връщаме създадения масив
    return maze;

}


//метод за визуализирането на лабиринта
void ShowMaze(Items[,] maze)
{
    //променливи за двете дължини на матрицата
    int x=maze.GetLength(0);
    int y=maze.GetLength(1);


    Console.SetCursorPosition(0, 0);

    //обхождаме матрицата
    for (int i=0; i<x ; i++)
    {
        for(int j=0; j<y; j++)
        {
            switch(maze[i,j])
            {
                //проверяваме какво има на дадената позиция

                //ако е стена
                case Items.Wall:
                    Console.Write('*');
                    break;

                //ако е пътека
                case Items.Path:
                    Console.Write(' ');
                    break;

                //ако е стъпка
                case Items.Step:
                    Console.Write('#');
                    break;

                //ако е краят на лабиринта
                case Items.End:Console.Write('$');break;
            }
        }
        Console.WriteLine();
    }
}


//метод за намирането на изхода
bool FindMazePath(Items[,]maze,int x,int y)
{
    //размерите на масива
    int a = maze.GetLength(0);
    int b = maze.GetLength(1);

    //проверяваме дали няма да излезем от размерите на лабиринта
    if (x < 0||x>=a) return false;
    if (y < 0 || y >= b) return false;

    //показваме текущото състояние на лабиринта
    ShowMaze(maze);

    //забавяне от 300 милисекунди, за да може потребителят да следи случващото се
    System.Threading.Thread.Sleep(300);

    //проверяваме какво има в тази клетка
    switch(maze[x,y])
    {
        //ако има стъпка или стена връщаме false, защото на тях не може да се стъпва
        case Items.Step:return false;
        case Items.Wall: return false;

        //ако това е краят на лабиринта връщаме true
        case Items.End:return true;
        
        //ако е пътека проверяваме какво има след нея и дали можем да продължим
        case Items.Path:

            //клетката се маркира като стъпка
            maze[x, y] = Items.Step;

            //методът се извиква рекурсивно за четирите съседни клетки и ако някоя от тях върне true ние също връщаме true
            if(FindMazePath(maze,x++,y)) return true;
            if(FindMazePath(maze,x--,y))return true;
            if (FindMazePath(maze, x, y++)) return true;
            if (FindMazePath(maze, x, y--)) return true;

            //в провивен слувай връщаме false
            return false;

            //връщаме false и по default
            default: return false;
    }
    
}


//елементите на лабиринта
enum Items
{
    Path,
    Step,
    Wall,
    End,
}