
Employer A = new Employer();

Console.WriteLine("Введите имя сотрудника");
A.Name = Console.ReadLine();
Console.WriteLine("Введите возраст сотрудника");
A.Age = int.Parse(Console.ReadLine());
Console.WriteLine("Введите должность сотрудника");
A.Work = Console.ReadLine();
Console.WriteLine("Введите зарплату сотрудника");
A.Pay = int.Parse(Console.ReadLine());

A.print();

class Employer
{
	private string name;
	private string work;
	private int age;
	private int pay;
	public string Name
	{
		get { return this.name != null ? this.name : "Нет данных"; }
		set { this.name = value; }
	}
	public string Work
	{
		get { return this.work != null ? this.work : "Нет данных"; }
		set { this.work = value; }
    }
	public int Age
	{
        get { return this.age; }
        set { this.age = (value < 1 || value > 100) ? 0 : value; }
    }
	public int Pay
	{
		get { return this.pay; }
		set { this.pay = value < 0 ? 0 : value;}
	}
	public void print()
	{
		Console.WriteLine($"Имя: {this.name}");
        Console.WriteLine($"Возраст: {this.age}");
        Console.WriteLine($"Должность: {this.work}");
        Console.WriteLine($"Зарплата: {this.pay}");
    }
}