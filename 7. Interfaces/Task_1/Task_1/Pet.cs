internal abstract class Pet
{
    protected string? name;
    protected uint age;
    public Pet(string nameP, uint ageP)
    {
        this.name = nameP;
        this.age = ageP;
    }
    public override string ToString()
    {
        return $"{this.name}, возрастом {this.age}";
    }

}
