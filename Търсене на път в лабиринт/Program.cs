Console.WriteLine("Enter x");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter y");
int y = int.Parse(Console.ReadLine());
Items[,] maze=GenerateMaze(y, x);
ShowMaze(maze);
if(FindMazePath(maze, 0, 0))Console.WriteLine("You reached the end!");
else Console.WriteLine("The end is not found!");
Items[,] GenerateMaze(int x,int y)
{
    Random r=new Random();
    Items[,] maze = new Items[x, y];
    for(int i = 0; i < x; i++)
    {
        for(int j=0; j < y; j++)
        {
            int num=r.Next(0,100);
            if (num % 5 == 0)
            {
                maze[i, j] = Items.Wall;
            }
            else maze[i,j] = Items.Path;
        }
    }
    maze[0, 0] = Items.Path;
    maze[x-1, y-1] = Items.End; 
    return maze;

}
void ShowMaze(Items[,] maze)
{
    
    int x=maze.GetLength(0);
    int y=maze.GetLength(1);
    Console.SetCursorPosition(0, 0);
    for (int i=0; i<x ; i++)
    {
        for(int j=0; j<y; j++)
        {
            switch(maze[i,j])
            {
                case Items.Wall:Console.Write('*');break;
                case Items.Path:Console.Write(' ');break;
                case Items.Step:Console.Write('#');break;
                case Items.End:Console.Write('$');break;
            }
        }Console.WriteLine();
    }
}
bool FindMazePath(Items[,]maze,int x,int y)
{
    int a = maze.GetLength(0);
    int b = maze.GetLength(1);
    if (x < 0||x>=a) return false;
    if (y < 0 || y >= b) return false;
    ShowMaze(maze);
    System.Threading.Thread.Sleep(300);
    switch(maze[x,y])
    {
        case Items.Step:return false;
        case Items.End:return true;
        case Items.Wall:return false;
        case Items.Path:
            maze[x, y] = Items.Step;
            if(FindMazePath(maze,x++,y)) return true;
            if(FindMazePath(maze,x--,y))return true;
            if (FindMazePath(maze, x, y++)) return true;
            if (FindMazePath(maze, x, y--)) return true;
            return false;
            default: return false;
    }
    
}
enum Items
{
    Path,
    Step,
    Wall,
    End,
}