
class Program
{
    static void Main(string[] args)
    {

        Shop Bica = new Shop();
        Console.WriteLine("Введите название магазина");
        Bica.setName(Console.ReadLine());
        Console.WriteLine("Введите адрес магазина");
        Bica.setLocation(Console.ReadLine());
        Console.WriteLine("Введите описание магазина");
        Bica.setData(Console.ReadLine());
        Console.WriteLine("Введите телефон магазина");
        Bica.setPhone(Console.ReadLine());
        Console.WriteLine("Введите Email магазина");
        Bica.setEmail(Console.ReadLine());

        Bica.show();

        Console.ReadKey();


    }
}

class Shop
{
    private string? name;
    private string? loc;
    private string? data;
    private string? phone;
    private string? email;

    public void setName(string nameP)
    {
        this.name = nameP;  
    }
    public void setLocation(string locP)
    {
        this.loc = locP;
    }
    public void setData(string dataP)
    {
        this.data = dataP;
    }
    public void setPhone(string phoneP)
    {
        this.phone = phoneP;
    }
    public void setEmail(string emailP)
    {
        this.email = emailP;
    }
    public string getName()
    {
        return this.name;
    }
    public string getLoc()
    {
        return this.loc;
    }
    public string getData()
    {
        return this.data;
    }
    public string getPhone()
    {
        return this.phone;
    }
    public string getEmail()
    {
        return this.email;
    }
    public void show()
    {
        Console.WriteLine($"Названия магазина: {this.getName()}");
        Console.WriteLine($"Адрес магазина: {this.getLoc()}");
        Console.WriteLine($"Описание магазина: {this.getData()}");
        Console.WriteLine($"Телефон: {this.getPhone()} / Email: {this.getEmail()}");
    }
}