Console.WriteLine("Enter year: ");
string input = Console.ReadLine();
int year=0;
if(int.Parse(input)>0) year = int.Parse(input);
else {Console.WriteLine("Wrong input!");Environment.Exit(1);}
bool leap=DateTime.IsLeapYear(year);
if (leap) Console.WriteLine($"The year {year} is leap!");
else Console.WriteLine($"The year {year} is NOT leap!");