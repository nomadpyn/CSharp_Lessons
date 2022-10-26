
    internal class Manager: Employer
    {
    string? work_department;
    public Manager(string nameP, string fnameP, int ageP, string work_locationP, int payP,string work_departmentP)
        : base(nameP, fnameP,ageP,work_locationP,payP)
    {
        this.work_department = work_departmentP;
    }
    public virtual new void Print()
    {
        base.Print();
        Console.WriteLine($"Отдел на работе: {this.work_department}");
    }
}
