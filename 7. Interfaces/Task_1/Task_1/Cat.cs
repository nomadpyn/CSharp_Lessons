internal class Cat : Pet, ICompPet, ICompanion
{
    bool isCompanion = true;
    string? description;
    string? master;
    public Cat(string nameP, uint ageP, string descP, string masterP) : base(nameP, ageP)
    {
        this.description = descP;
        this.master = masterP;
    }
    public bool IsCompanion
    {
        get { return isCompanion; }
    }
    public string Description
    {
        get { return this.description; }
        set { this.description = value; }
    }
    public string Master
    {
        get { return this.master; }
        set { this.master = value; }
    }
    public string TypeName()
    {
        return "Кошка";
    }
    public string Voice()
    {
        return "Мяу-Мяу";
    }
    public override string ToString()
    {
        string add = $"\nХозяин {this.master}: {this.description}";
        return $"{this.TypeName()} {base.ToString()} говорит {this.Voice()} {add}";
    }
}