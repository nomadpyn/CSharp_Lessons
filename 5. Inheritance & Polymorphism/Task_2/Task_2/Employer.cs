internal abstract class Employer : Human
{
    protected string? work_location;
    protected int pay;
    public Employer(string nameP, string fnameP, int ageP, string work_locationP, int payP)
    : base(nameP, fnameP, ageP)
    {
        this.work_location = work_locationP;
        this.pay = payP;
    }
    protected virtual new void Print()
    {
        base.Print();
        Console.WriteLine($"Зарплата: {this.pay}, Адрес работы: {this.work_location}");
    }
}