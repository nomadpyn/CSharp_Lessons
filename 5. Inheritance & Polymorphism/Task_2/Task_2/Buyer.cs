
    internal abstract class Buyer : Human
    {
    protected string? payment_type;
    public Buyer(string nameP, string fnameP, int age, string payment_typeP)
    : base(nameP, fnameP, age){
        this.payment_type = payment_typeP; 
    }
    protected virtual new void Print()
    {
        base.Print();
        Console.WriteLine($"Тип оплаты: {this.payment_type}");
    } 
    }
