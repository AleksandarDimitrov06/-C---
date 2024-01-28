using Печатни_произведения;
List<PrintedWork>works = new List<PrintedWork>();

Console.WriteLine("What type of Printed work you want to add 'Book' / 'Periodical' / 'Print'");
string input = Console.ReadLine();
while(!String.IsNullOrEmpty(input))
{ 
switch (input)
{
        case "Book":
            Console.WriteLine("What type of book you want to add 'Fiction' / 'Technical'");
            string book=Console.ReadLine();
            switch (book)
            {
                case "Fiction":
                    Console.Write("Enter 'Title' 'Language' 'Year' 'Author' 'Jenre' 'Number of heads'");
                    string[] items = Console.ReadLine().Split(' ').ToArray();
                    works.Add(new FictionBook(items[0], items[1], int.Parse(items[2]), items[3], items[4], int.Parse(items[5])));
                    break;
                case "Technical":
                    Console.Write("Enter 'Title' 'Language' 'Year' 'Author' 'Technical Field' 'Level - (Begginer/Advanced/Expert)'");
                    items= Console.ReadLine().Split(' ').ToArray();
                    if (items[5] == "Begginer")
                        works.Add(new TechnicalBook(items[0], items[1], int.Parse(items[2]), items[3], items[4], TechnicalBook.Levels.Begginer));
                    else if (items[5] =="Advanced")
                        works.Add(new TechnicalBook(items[0], items[1], int.Parse(items[2]), items[3], items[4], TechnicalBook.Levels.Advanced));
                    else
                        works.Add(new TechnicalBook(items[0], items[1], int.Parse(items[2]), items[3], items[4], TechnicalBook.Levels.Expert));
                    break;
            }break;
        case "Periodical":
            Console.WriteLine("What type of periodical you want to add 'Newspaper' / 'Magazine'");
            string periodical = Console.ReadLine();
            switch (periodical)
            {
                case "Newspaper":
                    Console.Write("Enter 'Title' 'Language' 'Period' 'Frequency' 'Type - (News/Sport/Yellow)' 'ColorPrint - (yes/no)'");
                    string[]items = Console.ReadLine().Split(' ').ToArray();
                    bool a=false;
                    if (items[5] == "yes")  a= true;         
                    if (items[4]=="News")
                        works.Add(new Newspaper(items[0], items[1], int.Parse(items[2]), int.Parse(items[3]),Newspaper.Types.News,a));
                    else if (items[4] == "Sport")
                        works.Add(new Newspaper(items[0], items[1], int.Parse(items[2]), int.Parse(items[3]), Newspaper.Types.Sport, a));
                    else works.Add(new Newspaper(items[0], items[1], int.Parse(items[2]), int.Parse(items[3]), Newspaper.Types.Yellow, a));
                    break;
                case "Magazine":
                    Console.Write("Enter 'Title' 'Language' 'Period' 'Frequency' 'What is it about'");
                    items= Console.ReadLine().Split(' ').ToArray();
                    works.Add(new Magazine(items[0], items[1], int.Parse(items[2]), int.Parse(items[3]), items[4]));
                    break;
            }break;
        case "Print":
            foreach(var a in works) Console.WriteLine(a.Print());
            break;
    }
    Console.WriteLine("What type of Printed work you want to add 'Book' / 'Periodical' / 'Print'");
    input = Console.ReadLine();
}