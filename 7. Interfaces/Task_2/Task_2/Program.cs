
House Dom = new House();
Team Brigada = new Team(2);
int Day = 1;
int choise;

while (Dom.isHouseReady()!=true)
{
    Console.WriteLine($"\n---------------\nДень {Day++}");
    Console.WriteLine("Что делаем?");
    Console.Write("1 - Работаем, 2 - Отчет : ");
    choise = Int32.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (choise)
    {
        case 1:
            {
                Brigada.Build(Dom);
                break;
            }
        case 2:
            {
                Brigada.Report(Dom);
                break;
            }
        default:
            {
                Console.WriteLine("Неправильный выбор");
                break;
            }

    }
    if (Dom.isHouseReady())
    {
        Console.WriteLine("\n***Поздравляем! Дом построен***\n");
    }
}