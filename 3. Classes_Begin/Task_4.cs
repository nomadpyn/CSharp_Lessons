

class Chld_Grdn
{
    private string? name;
    private string? loc;
    private string? type;
    private uint children;
    static private uint children_max;

    public Chld_Grdn(string name, string loc)
    {
        this.name = name;
        this.loc = loc;
    }
    static Chld_Grdn()
    {
        children_max = 64;
    }
    public void addChildren(uint child, string type)
    {
        this.children = child;
        this.type = type;
    }
    public void howMany()
    {
        double dol = (double)this.children / (double)children_max;

        dol *= 100;

        if (dol < 100)
        {
            Console.WriteLine($"У детского сада \"{this.name}\" недобор детей.");
            Console.WriteLine("Он заполнен на {0:F} %", dol);
        }
        else
        {
            Console.WriteLine($"У детского сада \"{this.name}\" перебор детей.");
            Console.WriteLine("Он переполнен на {0:F} %", dol- 100);
        }
    }
    public void showGarden()
    {
        Console.WriteLine($"Детский сад \"{this.name}\", по адресу {this.loc}.");
        Console.WriteLine($"В нем {this.children} детей, его профиль работы \"{this.type}\".");
    }
}