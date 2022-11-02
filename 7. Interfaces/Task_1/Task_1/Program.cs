
ICompPet [] House = new ICompPet[4];

House[0] = new Cat("Мурка", 4, "Рыжая кожка", "Маша");
House[1] = new Dog("Барбос", 6, "Дворняга", "Дед Максим");
House[2] = new Cow("Буренка", 5, "Хлев");
House[3] = new Chicken("Клава", 1, "Курятник");

foreach (ICompPet item in House)
{
    if (item.IsCompanion)
    {
        Console.WriteLine(item);
        Console.WriteLine();
    }
}