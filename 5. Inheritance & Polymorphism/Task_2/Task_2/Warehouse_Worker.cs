
internal class Warehouse_Worker : Employer
{
    string? warehouse_department;
    public Warehouse_Worker(string nameP, string fnameP, int ageP, string work_locationP, 
        int payP, string warehouse_departmentP)
        : base(nameP, fnameP, ageP, work_locationP, payP)
    {
        this.warehouse_department = warehouse_departmentP;
    }
    public virtual new void Print()
    {
        base.Print();
        Console.WriteLine($"Отдел на складе: {this.warehouse_department}");
    }
}