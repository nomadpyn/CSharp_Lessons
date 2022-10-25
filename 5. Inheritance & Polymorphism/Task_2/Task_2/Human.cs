  internal abstract class Human
    {
    protected string? name;
    protected string? fname;
    protected int age;
    public Human(string nameP,string fnameP, int ageP)
    {
        this.name = nameP;
        this.fname = fnameP;
        if (ageP > 0 && ageP < 100)
            this.age = ageP;
        else
            this.age = 1;
    }
    protected virtual void Print()
    {
        Console.WriteLine($"{this.fname} {this.name}, возраст: {this.age}");
    } 

    }

