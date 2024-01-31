using System.Transactions;
using Геометрични_фигури;

List<GeometryObject> geometryObjects=new List<GeometryObject>();
Start();

void Start()
{
    Console.WriteLine("Add object/Print objects/exit");
    string input = Console.ReadLine().ToLower();  
    while (true)
    {
        CheckInput(input);
        Console.WriteLine("Add object/Print objects/Exit");
        input = Console.ReadLine().ToLower();
    }
    
}
void CheckInput(string input)
{
    switch (input)
    {
        case "add object":
            Console.WriteLine("What object you want to add");
            PrintOptions();
            string GeometricObject= Console.ReadLine();
            CreateObject(GeometricObject);
            break;
        case "print objects":
            foreach(var a in geometryObjects) Console.WriteLine(a.ToString());
            break;
        case "exit":Environment.Exit(0); ;break;
            default: Console.WriteLine("Wrong input!");break;
    }
}
void PrintOptions()
{
    Console.WriteLine("1 - Point");
    Console.WriteLine("2 - Line");
    Console.WriteLine("3 - Triangle");
    Console.WriteLine("4 - Square");
    Console.WriteLine("5 - Rectangle");
    Console.WriteLine("6 - Circle");
    Console.WriteLine("7 - Cube");
    Console.WriteLine("8 - Pyramid");
    Console.WriteLine("9 - Prism");
    Console.WriteLine("10 - Cone");
    Console.WriteLine("11 - Cylinder");
    Console.WriteLine("12 - Sphere");
    Console.WriteLine("13 - Parallelogram");
    Console.WriteLine("14 - Trapezoid");
    Console.WriteLine("15 - ArbitraryPolygon");
    Console.WriteLine("16 - TruncatedPyramid");
    Console.WriteLine("17 - TruncatedCone");
    Console.WriteLine("18 - Ellipse");
}
void CreateObject(string geoobject)
{
    switch(geoobject)
    {
        case "1":
            Console.Write("Enter x:");
            double x=double.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            double y=double.Parse(Console.ReadLine());
            geometryObjects.Add(new Point("Point",x,y));
            break;
        case "2":
            Console.Write("Enter StartPoint");
            double startpoint = double.Parse(Console.ReadLine());
            Console.Write("Enter EndPoint");
            double endpoint = double.Parse(Console.ReadLine());
            geometryObjects.Add(new Line("Line", startpoint, endpoint));
            break;
        case "3":
            Console.Write("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c:");
            double c = double.Parse(Console.ReadLine());
            geometryObjects.Add(new Triangle("Triangle", a, b, c));
            break;
        case "4":
            Console.Write("Enter a:");
            a=double.Parse(Console.ReadLine());
            geometryObjects.Add(new Square("Square", a));
            break;
        case "5":
            Console.Write("Enter a:");
            a= double.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            b = double.Parse(Console.ReadLine());
            geometryObjects.Add(new Rectangle("Rectangle", a, b));
            break;
        case "6":
            Console.Write("Enter radius:");
            double radius=double.Parse(Console.ReadLine());
            geometryObjects.Add(new Circle("Circle", radius));
            break;
        case "7":
            Console.Write("Enter a:");
            a = double.Parse(Console.ReadLine());
            geometryObjects.Add(new Cube("Cube", a));
            break;
        case "8":
            Console.Write("Enter angles (3/4):");
            int angles = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter h:");
            double h = double.Parse(Console.ReadLine());
            geometryObjects.Add(new Pyramid("Pyramid", angles, a, h));
            break;
        case "9":
            Console.Write("Enter angles (3/4):");
            angles = int.Parse(Console.ReadLine());
            Console.Write("Enter a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter h:");
            h = double.Parse(Console.ReadLine());
            geometryObjects.Add(new Prism("Pyramid", angles, a, h));
            break;
        case "10":
            Console.Write("Enter radius:");
            radius = double.Parse(Console.ReadLine());
            Console.Write("Enter height:");
            h= double.Parse(Console.ReadLine());
            geometryObjects.Add(new Cone("Cone", radius, h));
            break;
        case "11":
            Console.Write("Enter radius");
            radius= double.Parse(Console.ReadLine());
            Console.Write("Enter height:");
            h=double.Parse(Console.ReadLine());
            geometryObjects.Add(new Cylinder("Cylinder",radius,h));
            break;
        case "12":
            Console.Write("Enter radius");
            radius=double.Parse(Console.ReadLine());
            geometryObjects.Add(new Sphere("Sphere", radius));
            break;
        case "13":
            Console.Write("Enter a:");
            a= double.Parse(Console.ReadLine());
            Console.Write("Enter b");
            b= double.Parse(Console.ReadLine());
            Console.Write("Enter height:");
            h = double.Parse(Console.ReadLine());
            geometryObjects.Add(new Parallelogram("Parallelogram", a, b, h));
            break;
        case "14":
            Console.Write("Enter a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter b:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter c:");
            c = double.Parse(Console.ReadLine());
            Console.Write("Enter d:");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Enter height:");
            h = double.Parse(Console.ReadLine());
            geometryObjects.Add(new Trapezoid("Trapezoid", a, b, c, d, h));
            break;
        case "15":
            Console.Write("Enter sides (with space between each):");
            double[]sides=Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            geometryObjects.Add(new ArbitraryPolygon("ArbitraryPolygon",sides));
            break;
        case "16":
            Console.Write("Enter a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter b");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter height:");
            h = double.Parse(Console.ReadLine());
            Console.Write("Enter k:");
            double k=double.Parse(Console.ReadLine());
            geometryObjects.Add(new ТruncatedPyramid("ТruncatedPyramid", a, b, h, k));
            break;
        case "17":
            Console.Write("Enter radius 1:");
            double r1=double.Parse(Console.ReadLine());
            Console.Write("Enter radius 2:");
            double r2=double.Parse(Console.ReadLine());
            Console.Write("Enter height:");
            h=double.Parse(Console.ReadLine());
            Console.Write("Enter l:");
            double l=double.Parse(Console.ReadLine());
            geometryObjects.Add(new TruncatedCone("TruncatedCone", r1, r2, h, l));
            break;
        case "18":
            Console.Write("Enter big radius:");
            r1=double.Parse(Console.ReadLine());
            Console.Write("Enter small radius:");
            r2=double.Parse(Console.ReadLine());
            geometryObjects.Add(new Ellipse("Ellipse",r1,r2));
            break;
        default:
            Console.WriteLine("Wrong input!");
            break;
    }
}