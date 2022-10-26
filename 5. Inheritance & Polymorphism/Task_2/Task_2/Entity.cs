internal class Entity : Buyer
{
    string? company;
    public Entity(string nameP, string fnameP, int age, string payment_typeP, string companyP)
        : base(nameP, fnameP, age, payment_typeP)
    {
        this.company = companyP;
    }
    public virtual new void Print()
    {
        base.Print();
        Console.WriteLine($"Место доставки: {this.company}");
    }
}
