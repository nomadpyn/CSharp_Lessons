    internal class Private_Person: Buyer
    {
    string? location;
    public Private_Person(string nameP, string fnameP, int age, string payment_typeP, string locationP)
        : base(nameP, fnameP, age, payment_typeP)
    {
        this.location = locationP;
    }
    public virtual new void Print()
    {
        base.Print();
        Console.WriteLine($"Место доставки: {this.location}");
    }
}
