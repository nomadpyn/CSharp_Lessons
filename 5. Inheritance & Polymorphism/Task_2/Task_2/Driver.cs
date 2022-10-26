internal class Driver : Employer
{
    string? transport;
    string? number;
    public Driver(string nameP, string fnameP, int ageP, string work_locationP,
        int payP, string transportP, string numberP)
        : base(nameP, fnameP, ageP, work_locationP, payP)
    {
        this.transport = transportP;
        this.number = numberP;
    }
    public virtual new void Print()
    {
        base.Print();
        Console.WriteLine($"Транспорт: {this.transport} - {this.number}");
    }
}