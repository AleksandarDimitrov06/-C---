using Адресна_книга;

Console.WriteLine("How much students you want to add");
int n=int.Parse(Console.ReadLine());
List<AddressEntry> items = new List<AddressEntry>();
for(int i = 0; i < n; i++)
{
    Console.Write("Name - ");
    string name=Console.ReadLine();
    Console.Write("Address - ");
    string address=Console.ReadLine();
    Console.Write("Number - ");
    int number=int.Parse(Console.ReadLine());
    items.Add(new AddressEntry(name, address,number));
}
bool end = false;
while(!end)
{
    Console.WriteLine("Choose operation 'Add' / 'Remove At' / 'Print' / 'End'");
    string operation = Console.ReadLine();
    switch (operation)
    {
        case "Add":
            Console.Write("Name - ");
            string name = Console.ReadLine();
            Console.Write("Address - ");
            string address = Console.ReadLine();
            Console.Write("Number - ");
            int number = int.Parse(Console.ReadLine());
            items.Add(new AddressEntry(name, address, number));
            break;
        case "Remove At":
            Console.Write("Enter postition");
            int position = int.Parse(Console.ReadLine());
            items.RemoveAt(position);
            Console.WriteLine("Add new");
            Console.Write("Name - ");
            name = Console.ReadLine();
            Console.Write("Address - ");
            address = Console.ReadLine();
            Console.Write("Number - ");
            number = int.Parse(Console.ReadLine());
            items.Insert(position, new AddressEntry(name, address, number));
            break;
        case "Print":
            foreach (var item in items) Console.WriteLine(item.ToString());
            break;
        case "End":end = true;break;
    }
}