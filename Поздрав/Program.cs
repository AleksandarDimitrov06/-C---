string studentname;
string coursename;
Console.Write("Enter the names of the student (with spaces between them): ");
studentname = Console.ReadLine();

Console.Write("Enter course: ");
coursename = Console.ReadLine();
string message = $"Hello {studentname} and welcome to {coursename}!";
Console.WriteLine(message);



