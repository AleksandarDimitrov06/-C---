//променлива за проверка на входните данни
bool Correct_Input = false;

//променлива, която ще съхранява входните данни
string input = null;

//променлива, която ще съхранява годината
int year = 0;

//цикъл за година
while (!Correct_Input)
{
    //подканваме потребителя да въведе година
    Console.WriteLine("Enter year: ");

     input= Console.ReadLine();

    //проверка на данните
    if (int.TryParse(input, out year) && (int.Parse(input) > 0))
    {
        //край на цикъла
        Correct_Input=true;

    }

    //в противен случай
    else
    {
        //показваме съобщение за грешни входни данни
        Console.WriteLine("Wrong input!");
    }
}


//проверяваме дали годината е високосна
bool leap=DateTime.IsLeapYear(year);

//ако е високосна
if (leap) Console.WriteLine($"The year {year} is leap!");

//ако не е високосна
else Console.WriteLine($"The year {year} is NOT leap!");