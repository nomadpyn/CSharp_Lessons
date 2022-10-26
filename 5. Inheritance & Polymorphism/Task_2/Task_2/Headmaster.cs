internal sealed class Headmaster : Human
{
    protected string? office_location;
    public Headmaster(string nameP, string fnameP, int age, string office_locationP)
    : base(nameP, fnameP, age)
    {
        this.office_location = office_locationP;
       
    }
    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Адрес кабинета: {this.office_location}");
    }
}