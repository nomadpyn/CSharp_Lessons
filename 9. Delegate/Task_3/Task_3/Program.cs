
List<Smartphone> Box = new List<Smartphone>
{
    new Smartphone("Xiaomi 12 Pro", "Black", 2022, 79990),
    new Smartphone("Iphone 14", "Blues", 2022, 99990),
    new Smartphone("Iphone 13 mini", "Rose", 2021, 79990),
    new Smartphone("Honor 70", "Green", 2021, 35990),
    new Smartphone("Xiaomi Redmi Note 9", "Midnight Grey", 2020, 32590),
    new Smartphone("Apple iPhone SE", "Red", 2020, 51990)
};

List<Smartphone> SP = Box.FindAll(searchPrice);

foreach (Smartphone item in SP)
{
    Console.WriteLine(item);
}

static bool searchPrice(Smartphone SF)
{
    return SF.Year == 2021;
}
