
enum ArticleType
{
    Food, Drinks, Instruments, Clothes, Toys
}
struct Article
{
    public uint id;
    public string name;
    public uint price;
    public ArticleType type;

    public void Print()
    {
        switch (type)
        {
            case ArticleType.Food:
                {
                    Console.Write("Еда");
                    break;
                }
            case ArticleType.Drinks:
                {
                    Console.Write("Напитки");
                    break;
                }
            case ArticleType.Instruments:
                {
                    Console.Write("Инструменты");
                    break;
                }
            case ArticleType.Clothes:
                {
                    Console.Write("Одежда");
                    break;
                }
            case ArticleType.Toys:
                {
                    Console.Write("Игрушки - ");
                    break;
                }
        }
        Console.WriteLine($"(id {id}) - {name} / {price} р.");
    }
}

class Program
{
    static void Main(String[] args)
    {
        Article B = new Article();

        Console.WriteLine("Введите id Товара");
        B.id = uint.Parse(Console.ReadLine());
        Console.WriteLine("Введите имя Товара");
        B.name = Console.ReadLine();
        Console.WriteLine("Введите цену Товара");
        B.price = uint.Parse(Console.ReadLine());
        Console.WriteLine("Что за товар?");
        Console.WriteLine("1 - Еда, 2 - Напитки, 3 - Инструменты, 4 - Одежда, 5 - Игрушки");
        switch (Console.ReadKey().KeyChar)
        {
            case '1':
                {
                    B.type = ArticleType.Food;
                    break;
                }
            case '2':
                {
                    B.type = ArticleType.Drinks;
                    break;
                }
            case '3':
                {
                    B.type = ArticleType.Instruments;
                    break;
                }
            case '4':
                {
                    B.type = ArticleType.Clothes;
                    break;
                }
            case '5':
                {
                    B.type = ArticleType.Toys;
                    break;
                }
        }
        Console.Clear();
        B.Print();

        Console.ReadKey();
    }
}