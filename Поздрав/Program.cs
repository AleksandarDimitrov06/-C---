using System.Linq;



//променлива, която ще съдържа името на ученика
string studentname=null;

//променлива,която ще съдържа името на курса
string coursename=null;


//променлива, която проверява въведеното име на ученика
bool Check_StudentName = false;

//докато не се въведе валидно име цикълът се повтаря
while (!Check_StudentName)
{
    Console.Write("Enter the name of the student: ");

    //проверяваме входните данни

    studentname = Console.ReadLine();

    //проверяваме дали всички символи са букви

    if(!Contains_Only_Letters(studentname.ToCharArray()))
        Console.WriteLine("Wrong input! Try again.");

    //проверяваме дали са въведени данни
    else if (string.IsNullOrEmpty(studentname))
        Console.WriteLine("Wrong input! Try again.");

    else 
        Check_StudentName = true;

}


//кодът се повтаря за името на курса
bool Check_CourseName = false;

while (!Check_CourseName)
{
    Console.Write("Enter the name of the couse: ");

    coursename = Console.ReadLine();


    if (!Contains_Only_Letters(coursename.ToCharArray()))
        Console.WriteLine("Wrong input! Try again.");

    else if (string.IsNullOrEmpty(coursename))
        Console.WriteLine("Wrong input! Try again.");

    else
        Check_CourseName = true;

}

//променлива, която ще съдържа поздрава
string message = $"Hello {studentname} and welcome to {coursename}!";

//показваме съобщението на конзолата
Console.WriteLine(message);




//метод за проверка на всички символи в масив
bool Contains_Only_Letters(char[] array)
{
    //ако някой от символите не е буква методът връща false
    foreach(var a in array)
    {
        if (Char.IsNumber(a) || Char.IsSymbol(a)) return false;
    }

    //в противен случай връща true
    return true;
}
