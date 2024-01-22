string[] stage1 = 
{ 
    "Вие сте в мрачна пещера. Пред вас има два тунела - 'ляво' и 'дясно'. Кой път избирате?" 
};
string[] stage2 =
{
    "Пред вас се появява чудовище. Изберете 'бий се' или 'бягай'.",
    "Продължавате напред и виждате река и дървено мостче. Изберете 'мини по моста' или 'заобиколи реката'."
};
string[] stage3 =
{
    "Успяхте да победите чудобището и продължавате напред.",
    "Успяхте да избягате от чудовището и продължавате напред.",
    "Преминахте по моста и достигнахте другия край на реката.",
    "Заобиколихте реката и продължавате напред."
};
string[] stage4 =
{
    "Изведнъж в далечината виждате светлина и намирате изхода от пещерата."
};
int s2 = -1;
int s3 = -1;
void Start()
{
    int count = 1;
    void ShowStage(int stage)
    {
        
        switch (stage)
        {
            case 1:
                Console.WriteLine(stage1[0]);
                count++;
                break;
            case 2:
                string input =Console.ReadLine();
                CheckStage2(input);
                Console.WriteLine(stage2[s2]);
                count++;
                break;
            case 3:
                input = Console.ReadLine();
                CheckStage3(input);
                Console.WriteLine(stage3[s3]);
                count++;
                break;
            case 4:
                Console.WriteLine(stage4[0]);
                count++;
                break;

        }
    }
    while (count <= 4)
    {
        ShowStage(count);
    }
    Console.WriteLine("Край на играта!");
}
void CheckStage2(string input)
{
    switch (input)
    {
        case "ляво": s2=0;break;
        case "дясно": s2= 1;break;
    }
}
void CheckStage3(string input)
{
    switch (input)
    {
        case "бий се":
            s3=0;
            break;
        case "бягай":
            s3=1;
            break;
        case "мини по моста":
            s3=2; 
            break;
        case "заобиколи реката":
            s3=3;
            break;
    }
}
Start();