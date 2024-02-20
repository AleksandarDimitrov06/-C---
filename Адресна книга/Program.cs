using System.Runtime.CompilerServices;
using Адресна_книга;


//правим си списък от хора и техните данни
List<AddressEntry> items = new List<AddressEntry>();

//опитваме се да прихванем грешка
try
{
    //въвеждаме броя на хората
    Console.WriteLine("How much people you want to add");
    int n = int.Parse(Console.ReadLine());

    //правим цикъл, който ще се повтаря толкова колкото е въвел потребителя
    for (int i = 0; i < n; i++)
    {

        //за всеки човек подканваме потребителя да въведе информация

        //име
        Console.Write("Name - ");
        string? name = Console.ReadLine();

        //адрес
        Console.Write("Address - ");
        string? address = Console.ReadLine();

        //телефон
        Console.Write("Number - ");
        int number = int.Parse(Console.ReadLine());

        //добадяме информацията в списъка
        items.Add(new AddressEntry(name, address, number));
    }



    //булева, която ще играе ролята на край за програмата
    bool end = false;

    //докато тя е false
    while (!end)
    {

        //подканваме потребителя да въведе операция
        Console.WriteLine("Choose operation 'Add' / 'Remove At' / 'Print' / 'End'");
        string operation = Console.ReadLine();

        //проверяваме какво е въвел 
        switch (operation)
        {

            //ако е въвел да добави
            case "Add":

                //подканваме го да въведе име,адрес и номер
                Console.Write("Name - ");
                string name = Console.ReadLine();
                Console.Write("Address - ");
                string address = Console.ReadLine();
                Console.Write("Number - ");
                int number = int.Parse(Console.ReadLine());

                //добавяме данните в списъка
                items.Add(new AddressEntry(name, address, number));
                break;

            //ако иска да премахне елемент по индекс
            case "Remove At":

                //въвеждаме позицията на елемента
                Console.Write("Enter postition");
                int position = int.Parse(Console.ReadLine());

                //премахваме го
                items.RemoveAt(position);

                //подканваме го да въведе нови данни
                Console.WriteLine("Add new");
                Console.Write("Name - ");
                name = Console.ReadLine();
                Console.Write("Address - ");
                address = Console.ReadLine();
                Console.Write("Number - ");
                number = int.Parse(Console.ReadLine());

                //добавяме новата информация на същата позиция
                items.Insert(position, new AddressEntry(name, address, number));
                break;

            //ако иска да се визуализира информацията 
            case "Print":

                //обхождаме елементите на списъка
                foreach (var item in items) 
                    
                    //изпечатваме информация за всеки един елемент
                    Console.WriteLine(item.ToString());
                break;

            //ако е въвел да се прекрати цикъла
            case "End": 
                //даваме край на програмата
                end = true;
                break;

            //ако не е въвел нито едно от горните връщаме грешка
            default:
                Console.WriteLine("Wrong input!");
                break;
        }

    }
}
catch (Exception)
{
    //излизаме от програмата
    Console.WriteLine("Wrong input!");
    Environment.Exit(1);
}