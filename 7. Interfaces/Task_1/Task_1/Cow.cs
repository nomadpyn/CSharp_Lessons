internal class Cow : Pet, ICompPet, IWorker
{
    bool isCompanion = false;
    string? location;
    string result = "Молоко";
    public Cow(string nameP,uint ageP,string locP) : base(nameP, ageP)
    {
        this.location = locP;
    }
    public bool IsCompanion
    {
        get { return this.isCompanion; }
    }
    public string Location
    {
        get { return this.location; }
        set { this.location = value; }
    }
    public string Result
    {
        get { return this.result; }
    }
    public string TypeName()
    {
        return "Корова";
    }
    public string Voice()
    {
        return "Му-Му-Му";
    }
    public override string ToString()
    {
        string add = $"\nЖивет в {this.location} и дает {this.result}";
        return $"{this.TypeName()} {base.ToString()} говорит {this.Voice()} {add}";
    }
}