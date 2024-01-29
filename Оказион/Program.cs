using Оказион;

List<User>users = new List<User>();
List<Advertisement>advertisements = new List<Advertisement>();
List<AuctionAdvertisement>auctionAdvertisements = new List<AuctionAdvertisement>();
List<DirectSaleAdvertisement>directSaleAdvertisements = new List<DirectSaleAdvertisement>();
User ActiveUser=null;
void Start()
{
    LoadUsersFromFile("users.txt");
    Console.WriteLine("Log in/Register");
    string input = Console.ReadLine();
    bool logged = false;
    while (!logged)
    {
        if (input == "Log in")
        {
            LogIn();
            logged = true;
        }
        else if (input == "Register")
        {
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(password)) { RegisterUser(username, password); logged = true; }
                else Console.WriteLine("Password cannot be empty.");
            }
            else Console.WriteLine("Username cannot be empty.");
        }
        else Console.WriteLine("Invalid input.");
        Console.WriteLine("Log in/Register");
        input = Console.ReadLine();
    }
    
    bool end = false;
    while (!end)
    {
        Console.WriteLine("Choose operation by number");
        ShowOptions();
        try
        {
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ShowActiveAdvertisements();
                    break;
                case 2:
                    ShowMyAdvertisements();
                    break;
                case 3:
                    ShowMyWonAdvertisements();
                    break;
                case 4:
                    Bidding();
                    break;
                case 5:
                    BuyItemDirecly();
                    break;
                case 6:
                    Console.WriteLine("Logging out...");
                    SaveUsersToFile("users.txt");
                    end = true;
                    break;
            }
        }
        catch (Exception) { Console.WriteLine("Wrong input!"); }
    }
    
}
void RegisterUser(string username, string password)
{
    if (!users.Contains(new User(username, password))) 
    {
        users.Add(new User(username, password));
        Console.WriteLine("You have registered succsessfuлly");
        LogIn();
    } 
    
}
void LoadUsersFromFile(string filename)
{
    if (File.Exists(filename))
    {
        users.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(" ");
                string username = parts[0];
                string password = parts[1];

                if (!users.Contains(new User(username,password)))
                {
                    RegisterUser(username, password);
                }

            }
        }
    }
}
void SaveUsersToFile(string filename)
{
    using (StreamWriter writer = new StreamWriter(filename))
    {
        foreach (var user in users)
        {
            writer.WriteLine(user.ToString());
        }
    }
}
void LogIn()
{
    Console.WriteLine("Enter user: 'name' 'password'");
    string[] parts = Console.ReadLine().Split(" ").ToArray();
    User user = new User(parts[0], parts[1]);
    if (users.Contains(user) && user.CheckPassword(user.password))
    {
        ActiveUser = user;
        Console.WriteLine("Welcome "+user.name);
    }
    else Console.WriteLine("Wrong username or password");
}
void ShowOptions()
{
    Console.WriteLine("1 - Show active advertisements");
    Console.WriteLine("2 - Show my advertisements");
    Console.WriteLine("3 - Show my won advertisements");
    Console.WriteLine("4 - Bidding by auction");
    Console.WriteLine("5 - Buy item directly");
    Console.WriteLine("6 - Log out");
}
void ShowActiveAdvertisements()
{
    if(advertisements.Count == 0)
    {
        Console.WriteLine("None");
        return;
    }
    foreach(var a in advertisements)
    {
        if(a.Active) Console.WriteLine(a.ToString());
    }
}
void ShowMyAdvertisements()
{
    ActiveUser.ShowAdvertisements();
}
void ShowMyWonAdvertisements()
{
    ActiveUser.ShowWonAdvertisements();
}
void Bidding()
{
    Console.WriteLine("Enter item");
    string item=Console.ReadLine();
    foreach(var a in auctionAdvertisements)
    {
        if (a.item.item == item) 
        {
            Console.WriteLine($"Starting price {a.start_price} - {a.end_price} until {a.end_date}");
            Console.WriteLine("How much you want to bid");
            double bid = double.Parse(Console.ReadLine());
            if (bid == a.end_price)
            {
                Console.WriteLine("You won!");
                ActiveUser.AddAdvertisement(a);
            }
        } 
    }    
}
void BuyItemDirecly()
{
    Console.WriteLine("Enter item");
    string item = Console.ReadLine();
    foreach(var a in directSaleAdvertisements)
    {
        if(a.item.item == item)
        {
            Console.WriteLine("The price is "+a.price);
            Console.WriteLine("You bought the item!");
            ActiveUser.AddAdvertisement(a);
        }
    }
}
Start();