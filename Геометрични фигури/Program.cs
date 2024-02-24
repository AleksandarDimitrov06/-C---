using System.Transactions;
using Геометрични_фигури;


//правим списък от геометрични обекти, в който ще съхраняваме създадените фигури
List<GeometryObject> geometryObjects=new List<GeometryObject>();


//стартираме програмата
Start();



//метод за стартиране на програмата
void Start()
{
    //подканваме потребителя да избере опция
    Console.WriteLine("Add object/Print objects/exit");

    //съхраняваме въведената информация
    string input = Console.ReadLine().ToLower();  


    //правим безкраен цикъл
    while (true)
    {

        //проверяваме какво е въвел потребителя
        CheckInput(input);

        //подканваме го да избере отново
        Console.WriteLine("Add object/Print objects/Exit");
        input = Console.ReadLine().ToLower();
    }
    
}



//мето, който проверява какво е въвел потребителя
void CheckInput(string input)
{

    //проверяваме
    switch (input)
    {
        //ако е избрал да въведе обект
        case "add object":

            //питаме го какъв обект иска да добави
            Console.WriteLine("What object you want to add");

            //показваме възможните опции
            PrintOptions();


            //взимаме въведената стойност
            string GeometricObject= Console.ReadLine();

            //създаваме фигурата
            CreateObject(GeometricObject);
            break;



        //ако е избрал да се визуализират всички регистрирани обекти
        case "print objects":


            //обхождаме списъка
            foreach(var a in geometryObjects) 
                
                //викаме метода ToString за всеки един от обектите и го визуализираме на екрана
                Console.WriteLine(a.ToString());
            break;


        //ако е избрал да излезе
        case "exit":
            
            //излизаме от програмта
            Environment.Exit(0); 
            break;

        //ако е въвел нещо различно изписваме грешка
        default: 
            Console.WriteLine("Wrong input!");
            break;
    }
}




//метод за визуализиране на всички възможни обекти
void PrintOptions()
{

    //точка
    Console.WriteLine("1 - Point");


    //линия
    Console.WriteLine("2 - Line");


    //триъгълник
    Console.WriteLine("3 - Triangle");


    //квадрат
    Console.WriteLine("4 - Square");


    //правоъгълник
    Console.WriteLine("5 - Rectangle");


    //кръг
    Console.WriteLine("6 - Circle");


    //куб
    Console.WriteLine("7 - Cube");


    //пирамида
    Console.WriteLine("8 - Pyramid");


    //призма
    Console.WriteLine("9 - Prism");


    //конус
    Console.WriteLine("10 - Cone");


    //цилиндър
    Console.WriteLine("11 - Cylinder");


    //сфера
    Console.WriteLine("12 - Sphere");


    //успоредник
    Console.WriteLine("13 - Parallelogram");


    //трапец
    Console.WriteLine("14 - Trapezoid");


    //произволен многоъгълник
    Console.WriteLine("15 - ArbitraryPolygon");


    //пресечена пирамида
    Console.WriteLine("16 - TruncatedPyramid");


    //пресечен конус
    Console.WriteLine("17 - TruncatedCone");


    //елипса
    Console.WriteLine("18 - Ellipse");
}



//метод за създаваме на обект
void CreateObject(string geoobject)
{

    //проверяваме каква опция е избрал потребителя
    switch(geoobject)
    {

        //точка
        case "1":

            //въвеждаме координатите на точката

            double x;
            double y;


            //х
            do
            {

                Console.Write("Enter x:");
            }
            while (!double.TryParse(Console.ReadLine(), out x));


            //у
            do
            {
                Console.Write("Enter y:");
            }
            while(!double.TryParse(Console.ReadLine(), out y));
                
           


            //в списъка с обекти добавяме нов обект - точка с посочените координати
            geometryObjects.Add(new Point("Point",x,y));
            break;





        //Линия
        case "2":


            //координати на началната точка
            double Start_X;
            double Start_Y;

            //x
            do
            {
                Console.WriteLine("Start Point");
                Console.WriteLine("Enter x");

            }
            while(!double.TryParse(Console.ReadLine(), out Start_X));

            //y
            do
            {
                Console.WriteLine("Enter y");
            }
            while(double.TryParse(Console.ReadLine(),null,out Start_Y));



            //координати на крайна точка
            double End_X;
            double End_Y;

            //x
            do
            {
                Console.WriteLine("End Point");
                Console.WriteLine("Enter x");

            }
            while (!double.TryParse(Console.ReadLine(), out End_X));

            //y
            do
            {
                Console.WriteLine("Enter y");
            }
            while (!double.TryParse(Console.ReadLine(), out End_Y));


            //създаваме линия и я добавяме в списъка с обекти
            geometryObjects.Add(new Line("Line",new Point("Start_Point",Start_X,Start_Y),new Point("End_Point",End_X,End_Y)));
            break;





        //Триъгълник
        case "3":

            //трите страни на триъгълника
            double a;
            double b;
            double c;

            //a
            do
            {
                Console.Write("Enter a:");
            }
            while(!double.TryParse(Console.ReadLine(), out a));


            //b
            do
            {
                Console.Write("Enter b:");
            }
            while (!double.TryParse(Console.ReadLine(), out b));



            //c
            do
            {
                Console.Write("Enter c:");
            }
            while (!double.TryParse(Console.ReadLine(), out c));
            

            //създаваме и добавяме триъгълника към списъка
            geometryObjects.Add(new Triangle("Triangle", a, b, c));
            break;






        //квадрат
        case "4":
            

            do
            {
                Console.Write("Enter a:");
            }
            while (!double.TryParse(Console.ReadLine(), out a));
            


            //създаваме фигурата и я добавяме към списъка
            geometryObjects.Add(new Square("Square", a));
            break;



        //правоъгълник
        case "5":


            //едната страна
            do
            {
                Console.Write("Enter a:");
            }
            while (!double.TryParse(Console.ReadLine(), out a));


            do
            {
                Console.Write("Enter b:");
            }
            while (!double.TryParse(Console.ReadLine(), out b));
            
            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Rectangle("Rectangle", a, b));
            break;


        
        //кръг
        case "6":

            //радиус
            double radius;
            do
            {
                Console.Write("Enter radius:");
            }
            while (!double.TryParse(Console.ReadLine(), out radius));

            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Circle("Circle", radius));
            break;




        //куб
        case "7":

            //страната на куба
            do
            {
                Console.Write("Enter a:");
            }
            while(!double.TryParse(Console.ReadLine(), out a));

            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Cube("Cube", a));
            break;




        //пирамида
        case "8":

            //брой ъгли на основата
            int angles;

            do
            {
                Console.Write("Enter angles (3/4):");
            }

            //проверяваме какво е въвел потребителя 
            while (int.TryParse(Console.ReadLine(), out angles)&&angles==3||angles==4);

            //страната на пирамидата

            do
            {
                Console.WriteLine("Enter a:");
            }
            while (!double.TryParse(Console.ReadLine(), out a));


            //височината на пирамидата
            double h;

            do
            {
                Console.WriteLine("Enter h:");
            }
            while (!double.TryParse(Console.ReadLine(), out h));




            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Pyramid("Pyramid", angles, a, h));
            break;





        //призма
        case "9":

            //брой ъгли

            do
            {
                Console.Write("Enter angles (3/4):");
            }
            while (int.TryParse(Console.ReadLine(), out angles) && angles < 3 || angles > 4);



            //страна

            do
            {
                Console.Write("Enter a:");
            }
            while (!double.TryParse(Console.ReadLine(), out a));


            //височина

            do
            {
                Console.WriteLine("Enter h:");
            }
            while (!double.TryParse(Console.ReadLine(), out h));


            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Prism("Prism", angles, a, h));
            break;





        //конус
        case "10":

            //радиус на основата
            do
            {
                Console.Write("Enter radius:");
            }
            while (!double.TryParse(Console.ReadLine(), out radius));


            //височина на конуса

            do
            {
                Console.WriteLine("Enter h:");
            }
            while (!double.TryParse(Console.ReadLine(), out h));


            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Cone("Cone", radius, h));
            break;





        //цилиндър
        case "11":

            //радиус

            do
            {
                Console.Write("Enter radius:");
            }
            while (!double.TryParse(Console.ReadLine(), out radius));



            //височина

            do
            {
                Console.WriteLine("Enter h:");
            }
            while (!double.TryParse(Console.ReadLine(), out h));




            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Cylinder("Sphere",radius,h));
            break;




        //сфера
        case "12":

            //радиус

            do
            {
                Console.Write("Enter radius:");
            }
            while (!double.TryParse(Console.ReadLine(), out radius));


            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Sphere("Sphere", radius));
            break;




        //успоредник
        case "13":

            //първата страна

            do
            {
                Console.Write("Enter a:");
            }
            while (!double.TryParse(Console.ReadLine(), out a));



            //втора страна

            do
            {
                Console.Write("Enter b");
            }
            while(!double.TryParse(Console.ReadLine(), out b));


            //височина

            do
            {
                Console.Write("Enter height:");
            }
            while (!double.TryParse(Console.ReadLine(), out h));


            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Parallelogram("Parallelogram", a, b, h));
            break;





        //трапец
        case "14":

            //първа страна

            do
            {
                Console.Write("Enter a:");
            }
            while (!double.TryParse(Console.ReadLine(), out a));


            //втора страна

            do
            {
                Console.Write("Enter b:");
            }
            while (!double.TryParse(Console.ReadLine(), out b));


            //трета страна

            do
            {
                Console.Write("Enter c:");
            }
            while (!double.TryParse(Console.ReadLine(), out c));


            //четвърта страна

            double d;
            do
            {
                Console.Write("Enter d:");
            }
            while (!double.TryParse(Console.ReadLine(), out d));


            //височина

            do
            {
                Console.Write("Enter h:");
            }
            while (!double.TryParse(Console.ReadLine(), out h));




            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Trapezoid("Trapezoid", a, b, c, d, h));
            break;






        //произволен многоъгълник

        case "15":

            //въвеждаме страните на фигурата
            double[] sides = null;

            bool Correct_Input = false;


            while(!Correct_Input)
            {
                try
                {
                    Console.Write("Enter sides (with space between each):");
                    sides = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                    Correct_Input = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input!");
                }
                
            }



            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new ArbitraryPolygon("ArbitraryPolygon",sides));
            break;





        //пресечена пирамида
        case "16":

            //първата страна на основата
            do
            {
                Console.Write("Enter a:");
            }
            while (!double.TryParse(Console.ReadLine(), out a));


            //втора страна

            do
            {
                Console.Write("Enter b");
            }
            while (!double.TryParse(Console.ReadLine(), out b));


            //височина

            do
            {
                Console.Write("Enter height:");
            }
            while (!double.TryParse(Console.ReadLine(), out h));



            //височина на околна страна
            double k;

            do
            {
                Console.Write("Enter k:");
            }
            while (!double.TryParse(Console.ReadLine(), out k));




            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new ТruncatedPyramid("ТruncatedPyramid", a, b, h, k));
            break;






        //пресечен конус
        case "17":

            //голям радиус
            double r1;

            do
            {
                Console.Write("Enter radius 1:");
            }
            while(!double.TryParse(Console.ReadLine(), out r1));


            //малък радиус
            double r2;

            do
            {
                Console.Write("Enter radius 2:");
            }
            while (!double.TryParse(Console.ReadLine(), out r2));


            //височина

            do
            {
                Console.Write("Enter height:");
            }
            while (!double.TryParse(Console.ReadLine(), out h));



            //образуваща на конус
            double l;

            do
            {
                Console.Write("Enter l:");
            }
            while(!double.TryParse(Console.ReadLine(), out l));



            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new TruncatedCone("TruncatedCone", r1, r2, h, l));
            break;






        //Елипса
        case "18":

            //гоялм радиус

            do
            {
                Console.Write("Enter big radius:");
            }
            while (!double.TryParse(Console.ReadLine(), out r1));




            //малък радиус
            do
            {
                Console.Write("Enter small radius:");
            }
            while (!double.TryParse(Console.ReadLine(), out r2));



            //създаваме обекта и го добавяме към списъка
            geometryObjects.Add(new Ellipse("Ellipse",r1,r2));
            break;





        //ако потребителят е въвел друга информация показваме съобщение за грешка
        default:
            Console.WriteLine("Wrong input!");
            break;
    }
}