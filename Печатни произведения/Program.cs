using System.Diagnostics.Tracing;
using Печатни_произведения;

//списък от печатни произведения 
List<PrintedWork>works = new List<PrintedWork>();


//подканваме потребителя да въведе какъв вид печатно произведение иска да добави
Console.WriteLine("What type of Printed work you want to add 'Book' / 'Periodical' / 'Print'");
string input = Console.ReadLine();



//докато не е въвел празен ред
while(!String.IsNullOrEmpty(input))
{ 
    //проверяваме какво е въвел
    switch (input)
    {

        //ако е книга
        case "Book":

            //подканваме потребителя да въведе какъв вид книга иска да добави
            Console.WriteLine("What type of book you want to add 'Fiction' / 'Technical'");
            string book=Console.ReadLine();

            //проверяваме какво е въвел
            switch (book)
            {

                //ако е въвел художествена
                case "Fiction":

                    //подканваме потребителя да въведе необходимите данни

                    Console.Write("Enter 'Title' 'Language' 'Year' 'Author' 'Jenre' 'Number of heads'");
                    string[] items;


                    //опитваме се да прихванем грешка
                    try
                    {
                        items = Console.ReadLine().Split(' ').ToArray();
                        works.Add(new FictionBook(items[0], items[1], int.Parse(items[2]), items[3], items[4], int.Parse(items[5])));
                    }
                    catch (Exception)
                    {
                        //ако е въвел грешна информация извеждаме съобщение
                        Console.WriteLine("Wrong input");
                    }
                    break;



                //ако е въвел техническа книга
                case "Technical":

                    //подканваме го да въведе необходимите данни
                    Console.Write("Enter 'Title' 'Language' 'Year' 'Author' 'Technical Field' 'Level - (Begginer/Advanced/Expert)'");

                    //прихващаме грешка
                    try
                    {

                        items = Console.ReadLine().Split(' ').ToArray();


                        if (items[5] == "Begginer")
                            works.Add(new TechnicalBook(items[0], items[1], int.Parse(items[2]), items[3], items[4], TechnicalBook.Levels.Begginer));
                        else if (items[5] == "Advanced")
                            works.Add(new TechnicalBook(items[0], items[1], int.Parse(items[2]), items[3], items[4], TechnicalBook.Levels.Advanced));
                        else
                            works.Add(new TechnicalBook(items[0], items[1], int.Parse(items[2]), items[3], items[4], TechnicalBook.Levels.Expert));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong input!");
                    }
                    
                    break;
            }
            break;



        //ако е въвел периодично издание
        case "Periodical":

            //подканваме потребителя да въведе какъв вид периодично издание иска да добави
            Console.WriteLine("What type of periodical you want to add 'Newspaper' / 'Magazine'");
            string periodical = Console.ReadLine();

            //проверяваме
            switch (periodical)
            {

                //ако е въвел вестник
                case "Newspaper":

                    //подканваме го да въведе необходимите данни
                    Console.Write("Enter 'Title' 'Language' 'Start Of Period' 'End Of Period' 'Frequency' 'Type - (News/Sport/Yellow)' 'ColorPrint - (yes/no)'");
                    string[] items;

                    //проверяваме за грешка

                    try
                    {
                        items = Console.ReadLine().Split(' ').ToArray();

                        //проверяваме дали вестника е цветен
                        bool Has_Color_Print = false;
                        if (items[5] == "yes") Has_Color_Print = true;

                        //проверяваме каква е темата на вестника

                        //ако е новини
                        if (items[4] == "News")
                            works.Add(new Newspaper(items[0], items[1], int.Parse(items[2]), int.Parse(items[3]), int.Parse(items[4]), Newspaper.Types.News,Has_Color_Print));

                        //ако е спорт
                        else if (items[4] == "Sport")
                            works.Add(new Newspaper(items[0], items[1], int.Parse(items[2]), int.Parse(items[3]), int.Parse(items[4]),Newspaper.Types.Sport, Has_Color_Print));

                        //ако е друго
                        else works.Add(new Newspaper(items[0], items[1], int.Parse(items[2]), int.Parse(items[3]), int.Parse(items[4]), Newspaper.Types.Yellow, Has_Color_Print));
                    }
                    //ако прихванем грешка
                    catch (Exception)
                    {
                        //извеждаме съобщение
                        Console.WriteLine("Wrong input!");
                    }
                    break;



                //ако е списание
                case "Magazine":

                    //подканваме го да въведе необходимите данни
                    Console.Write("Enter 'Title' 'Language' 'Start Of Period' 'End Of Period' 'Frequency' 'What is it about'");

                    //проверяваме за неизправност
                    try
                    {
                        items = Console.ReadLine().Split(' ').ToArray();
                        works.Add(new Magazine(items[0], items[1], int.Parse(items[2]), int.Parse(items[3]),int.Parse(items[4]), items[5]));
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Wrong input!");
                    }

                    break;
            }
            break;



        //ако иска да види информация за вскички въведени произведения
        case "Print":

            //всяко произведение го извеждаме на екрана
            foreach(var work in works) Console.WriteLine(work.Print());
            break;


        //ако е въвел нещо друго
        default:
            Console.WriteLine("Wrong input!");
            break;
    }


    //отново подканваме потребителя да въведе какъв вид печатно произведение иска да добави
    Console.WriteLine("What type of Printed work you want to add 'Book' / 'Periodical' / 'Print'");
    input = Console.ReadLine();
}




