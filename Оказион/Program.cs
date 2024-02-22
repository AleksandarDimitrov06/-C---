using Оказион;


//създаваме списък от потребители
List<User>users = new List<User>();

//създаваме списък от обяви
List<Advertisement>advertisements = new List<Advertisement>();

//списък от търгове
List<AuctionAdvertisement>auctionAdvertisements = new List<AuctionAdvertisement>();

//списък от дирекни обяви
List<DirectSaleAdvertisement>directSaleAdvertisements = new List<DirectSaleAdvertisement>();

//променлива, която ще съхранява текущия потребител
User ActiveUser=null;


//метод за начало на програмата
void Start()
{
    //зареждаме текущите потребители от файл на име "users.txt"
    LoadUsersFromFile("users.txt");

    //подканваме потребителя да въведе опция за влизане в системата
    Console.WriteLine("Log in/Register");
    string input = Console.ReadLine();

    //булева, която ще проверява дали влизането в системата е завършено
    bool logged = false;

    //докато потребителя не е в системата
    while (!logged)
    {

        //проверяваме каква опция е избрал
        if (input == "Log in")
        {
            //ако вече се е регистрирал
            if(LogIn())
                logged = true;

            else Console.WriteLine("Wrong input!"); 

        }

        //ако иска да си направи регистрация
        else if (input == "Register")
        {
            //подканваме потребителя да въведе име
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();

            //подканваме потребителя да въведе парола
            if (!string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(password)) 
                { 
                    RegisterUser(username, password); logged = true; 
                
                }
                else Console.WriteLine("Password cannot be empty.");
            }
            else Console.WriteLine("Username cannot be empty.");
        }

        else Console.WriteLine("Invalid input.");

        //подканваме потребителя отново да въведе опция за влизане
        Console.WriteLine("Log in/Register");
        input = Console.ReadLine();
    }
    

    //булева, която ще проверява за край на програмата
    bool end = false;


    while (!end)
    {

        //подканваме потребителя да избере опция
        Console.WriteLine("Choose operation by number");

        //визуализираме възможните опции
        ShowOptions();


        try
        {
            //взимаме избраната опция
            int option = int.Parse(Console.ReadLine());

            //проверяваме
            switch (option)
            {

                //ако потребителя е избрал да се покажат активните обяви
                case 1:
                    ShowActiveAdvertisements();
                    break;

                //ако потребителя е избрал да се покажат неговите артикули
                case 2:
                    ShowMyAdvertisements();
                    break;


                //ако потребителя е избрал да се покажат неговите спечелени артикули
                case 3:
                    ShowMyWonAdvertisements();
                    break;



                //ако потребителя е избрал да търгува
                case 4:
                    Bidding();
                    break;


                //ако потребителя е избрал да закупи артикул директно
                case 5:
                    BuyItemDirecly();
                    break;


                //ако потребителя е избрал да излезе
                case 6:
                    Console.WriteLine("Logging out...");
                    SaveUsersToFile("users.txt");
                    end = true;
                    break;
            }
        }

        catch (Exception) 
        { 
            Console.WriteLine("Wrong input!"); 
        }
    }
    
}


//метод за регистриране на потребител
void RegisterUser(string username, string password)
{
    //проверяваме дали съществува такъв потребител
    if (!users.Contains(new User(username, password))) 
    {
        //добавяме го към списъка с потребители
        users.Add(new User(username, password));

        //изписваме съобщение за успешна регистрация 
        Console.WriteLine("You have registered succsessfuлly");

        //автоматично се задава като текущ потребител
        LogIn();
    } 
    else
    {
        //изписваме съобщение за грешка
        Console.WriteLine("The user already exist!");
    }
    
}


//метод за извличането на потребители от файл
void LoadUsersFromFile(string filename)
{
    //проверяваме дали потребителя съществува
    if (File.Exists(filename))
    {
        //изчисваме списъка от предходна информация
        users.Clear();

        //създаваме чепец на файлове 
        using (StreamReader reader = new StreamReader(filename))
        {
            //променлива, която ще съхранява информацията за всеки ред
            string line;

            //взимаме стойностите на редовете, докато не достигнем края на файла
            while ((line = reader.ReadLine()) != null)
            {
                //всеки ред е съставен от името и паролата разделени с интервал
                //създаваме масив, който ще ни помогне да извлечен данните от реда
                string[] parts = line.Split(" ");

                //името
                string username = parts[0];

                //паролата
                string password = parts[1];


                //проверяваме дали потребителя съществува
                if (!users.Contains(new User(username,password)))
                {
                    //регистриваме го в системата
                    RegisterUser(username, password);
                }

            }
        }
    }
}


//метод за записването на потребители във файл
void SaveUsersToFile(string filename)
{

    //създаваме променлива за въвеждане на информация във файл
    using (StreamWriter writer = new StreamWriter(filename))
    {

        //обхождаме всички потребители
        foreach (var user in users)
        {
            //всеки потребител го записваме във файла
            writer.WriteLine(user.ToString());
        }
    }
}


//метод за влизане в системата
bool LogIn()
{
    //подканваме потребителя да въведе име и парола
    Console.WriteLine("Enter user: 'name' 'password'");

    //взимаме дадената информация
    string[] parts = Console.ReadLine().Split(" ").ToArray();

    //създаваме потребител с зададените име и парола
    User user = new User(parts[0], parts[1]);

    //проверяваме дали съществува такъв потребител и проверяваме дали паролата е правилна
    if (users.Contains(user) && user.CheckPassword(user.password))
    {
        //задаваме активен потребител
        ActiveUser = user;

        //съобщение за успешно влизане в системата
        Console.WriteLine("Welcome " + user.name);

        return true;
    }
    else return false;

    //съобщение за грешка
    else Console.WriteLine("Wrong username or password");
}


//метод за визуализиране на възможните опции
void ShowOptions()
{
    //показване на активните обяви
    Console.WriteLine("1 - Show active advertisements");

    //показване на личните обяви
    Console.WriteLine("2 - Show my advertisements");

    //показване на личните спечелени обяви
    Console.WriteLine("3 - Show my won advertisements");

    //търгуване за артикул
    Console.WriteLine("4 - Bidding by auction");

    //закупуване на артикул директно
    Console.WriteLine("5 - Buy item directly");

    //излизане от системата
    Console.WriteLine("6 - Log out");
}



//метод за визуализиране на активните обяви
void ShowActiveAdvertisements()
{
    //проверяваме дали съществуват обяви
    if(advertisements.Count == 0)
    {
        Console.WriteLine("None");
        return;
    }

    //обхождаме ги
    foreach(var a in advertisements)
    {
        //проверяваме дали са активни
        if(a.Active) 

            //изпечатваме ги на конзолата
            Console.WriteLine(a.ToString());
    }
}


//метод за визуализация на личните обяви
void ShowMyAdvertisements()
{
    //викаме необходимия метод
    ActiveUser.ShowAdvertisements();
}


//метод за визуализация на спечелените лични обяви
void ShowMyWonAdvertisements()
{
    //викаме необходимия метод
    ActiveUser.ShowWonAdvertisements();
}


//метод за търгуване
void Bidding()
{
    //подканваме потребителя да въведе артикул
    Console.WriteLine("Enter item");
    string? item=Console.ReadLine();

    //обхождаме списъка с продукти за търг
    foreach(var a in auctionAdvertisements)
    {
        //проверяваме дали името на артикула е намерено
        if (a.item.item == item) 
        {
            //визуализираме началната и крайната цена, както и края на обявата
            Console.WriteLine($"Starting price {a.start_price} - {a.end_price} until {a.end_date}");

            //подканваме потребителя да въведе сума
            double bid;
            do
            {
                Console.WriteLine("How much you want to bid");
                
            }
            while(double.TryParse(Console.ReadLine(), out bid));

            //проверяваме дали потребителя е въвел максималната цена
            if (bid == a.end_price)
            {
                //потребителят директно печели артикула
                Console.WriteLine("You won!");
                ActiveUser.AddAdvertisement(a);
            }
        } 
    }    
}


//метод за закупуване на артикул директно
void BuyItemDirecly()
{
    //подканваме потребителя да въведе артикул
    Console.WriteLine("Enter item");
    string? item = Console.ReadLine();

    //обхождаме всички обяви за директно закупуване
    foreach(var a in directSaleAdvertisements)
    {

        //проверяваме дали е намерен такъв артикул
        if(a.item.item == item)
        {
            //визуализираме цената
            Console.WriteLine("The price is "+a.price);

            //запитваме потребителя дали иска да закупи артикула
            Console.WriteLine("Do you want to buy the item ('yes'/'no')");

            //проверяваме какво е въвел
            switch (Console.ReadLine())
            {
                //ако потребителя иска да закупит артикула
                case "yes":
                    Console.WriteLine("You bought the item!");

                    //добавяме го в списъка на потребителя
                    ActiveUser.AddAdvertisement(a);
                    break;

                //в противен слувай не се случва нищо
                default:
                    break;

            }
            
        }
    }
}
Start();