//променлива за първия коефициент

double a=0;


//приканваме потребителя да въведе число и проверяваме входние данни

bool Check_Input_For_A = false;

while (!Check_Input_For_A)
{
    Console.Write("Enter a: ");
    //проверяваме въведените данни
    Check_Input_For_A=double.TryParse(Console.ReadLine(), out a);
    
    //на конзолата се изписва съобщение ако данните не са валидни

    if(!Check_Input_For_A) Console.WriteLine("Wrong input! Try again.");
}


//другите коефициенти се имплементират по същия начин

//втори коефициент

double b=0;

bool Check_Input_For_B = false;

while (!Check_Input_For_B)
{
    Console.Write("Enter b: ");
    
    Check_Input_For_B = double.TryParse(Console.ReadLine(), out b);


    if (!Check_Input_For_B) Console.WriteLine("Wrong input! Try again.");
}



//трети коефициент
double c=0;

bool Check_Input_For_C = false;

while (!Check_Input_For_C)
{
    Console.Write("Enter c:");

    Check_Input_For_C=double.TryParse(Console.ReadLine(),out c);

    if (!Check_Input_For_C) Console.WriteLine("Wrong input! Try again."); 
}


//правим променлива, която пресмята дискриминантата

double discriminant = b * b - 4 * a * c;

//показваме резултата на конзолата
Console.WriteLine($"Discriminant = {discriminant}");