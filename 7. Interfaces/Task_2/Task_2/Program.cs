
House Dom = new House();
Team Brigada = new Team(2);
int Day = 1;
int choise;

while (Dom.isHouseReady()!=true)
{
    Console.WriteLine($"День {Day++}");
    Console.WriteLine("Что делаем?");
    Console.WriteLine("1 - Работаем, 2 - Отчет");
    choise = Int32.Parse(Console.ReadLine());
    Console.Clear();
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
    Console.WriteLine(Dom.isHouseReady() ? "Дом построен" : "Дом еще не построен");
}