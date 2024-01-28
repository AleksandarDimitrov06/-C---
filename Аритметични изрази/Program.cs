using Аритметични_изрази;
Console.WriteLine("Choose operation 'Unary'/'Binary'");
string operation = Console.ReadLine();
while(!String.IsNullOrEmpty(operation))
{
    switch (operation)
    {
        case "Unary":
            Console.WriteLine("Enter number");
            UnaryOperationExpression e=new UnaryOperationExpression(int.Parse(Console.ReadLine()));
            Console.WriteLine(e.ToString());
            break;
        case "Binary":
            Console.WriteLine("Enter number 1");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("Choose operation '+' / '-' / '*' / '/'");
            char opr=char.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int number2=int.Parse(Console.ReadLine());
            BinaryOperationExpression a=new BinaryOperationExpression(number1, number2,opr);
            Console.WriteLine(a.ToString());
            break;
    }
    Console.WriteLine("Choose operation 'Unary'/'Binary'");
    operation = Console.ReadLine();

}