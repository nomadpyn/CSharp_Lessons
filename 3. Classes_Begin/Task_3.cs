
class Program
{
    static void Main(string[] args)
    {
        Student A = new Student("Иван", "Петрович", "Борисов", 25, "СТ3");

        A.setScores();
        A.show();

        Console.ReadKey();
    }
}

enum school
{

    program, admin, design
}

class Student
{
    private string? name;
    private string? fname;
    private string? sname;
    private uint? age;
    private string? group;
    private int [][] arr_s = new int[3][];

    public Student(string? nameP, string? fnameP, string? snameP, uint? ageP, string? groupP)
    {
        this.name = nameP;
        this.fname = fnameP;
        this.sname = snameP;
        this.age = ageP;
        this.group = groupP;
    }

    public void setScores()
    {
        Console.WriteLine("Введите оценки по программированию через пробел");
        string[] arr = Console.ReadLine().Split();
        arr_s[((int)school.program)] = new int[arr.Length];
        for (int i = 0; i < arr_s[0].Length; i++)
        {
            arr_s[((int)school.program)][i] = int.Parse(arr[i]);
        }
        Console.WriteLine("Введите оценки по администрированию через пробел");
        arr = Console.ReadLine().Split();
        arr_s[((int)school.admin)] = new int[arr.Length];
        for (int i = 0; i < arr_s[1].Length; i++)
        {
            arr_s[((int)school.admin)][i] = int.Parse(arr[i]);
        }
        Console.WriteLine("Введите оценки по дизайну через пробел");
        arr = Console.ReadLine().Split();
        arr_s[((int)school.design)] = new int[arr.Length];
        for (int i = 0; i < arr_s[2].Length; i++)
        {
            arr_s[((int)school.design)][i] = int.Parse(arr[i]);
        }
    }
    public void getScore()
    {
        Console.WriteLine("По какому предмету получить оценки?");
        Console.WriteLine("1 - Прог, 2 - Админ, 3- Дизайн, 0 - все предметы сразу");
        switch (Console.ReadKey().KeyChar)
        {
            case '1':
                {
                    Console.WriteLine($"\nУ вас {arr_s[((int)school.program)].Length} оценок по программированию");
                    for(int i=0;i< arr_s[((int)school.program)].Length; i++)
                    {
                        Console.Write(arr_s[((int)school.program)][i]+"\t"); 
                    }
                    Console.WriteLine();
                    break;
                }
            case '2':
                {
                    Console.WriteLine($"\nУ вас {arr_s[((int)school.admin)].Length} оценок по администрированию");
                    for (int i = 0; i < arr_s[((int)school.admin)].Length; i++)
                    {
                        Console.Write(arr_s[((int)school.admin)][i] + "\t");
                    }
                    Console.WriteLine();
                    break;
                }
            case '3':
                {
                    Console.WriteLine($"\nУ вас {arr_s[((int)school.design)].Length} оценок по дизаину");
                    for (int i = 0; i < arr_s[((int)school.design)].Length; i++)
                    {
                        Console.Write(arr_s[((int)school.design)][i] + "\t");
                    }
                    Console.WriteLine();
                    break;
                }
            case '0':
                {
                    Console.WriteLine($"\nПрогаммирование");
                    for (int i = 0; i < arr_s[((int)school.program)].Length; i++)
                    {
                        Console.Write(arr_s[((int)school.program)][i] + "\t");
                    }
                    Console.WriteLine($"\nАдминистирование");
                    for (int i = 0; i < arr_s[((int)school.admin)].Length; i++)
                    {
                        Console.Write(arr_s[((int)school.admin)][i] + "\t");
                    }
                    Console.WriteLine($"\nДизаин");
                    for (int i = 0; i < arr_s[((int)school.design)].Length; i++)
                    {
                        Console.Write(arr_s[((int)school.design)][i] + "\t");
                    }
                    Console.WriteLine();
                    break;
                }
            default:
                {
                    Console.WriteLine("\nВы ничего не выбрали");
                    break;
                }

        }
    }
    public double getAvProg()
    {
        return this.arr_s[((int)school.program)].Average();
    }
    public double getAvAdmin()
    {
        return this.arr_s[((int)school.admin)].Average();
    }
    public double getAvDes()
    {
        return this.arr_s[((int)school.design)].Average();
    }
    public void show()
    {
        Console.WriteLine($"Студент {this.name} {this.fname} {this.sname}. Возраст {this.age}");
        Console.WriteLine($"Группа {this.group}. Средние оценки:");
        Console.Write($"Программирование {this.getAvProg()}, ");
        Console.Write($"Администрирование {this.getAvAdmin()}, ");
        Console.WriteLine($"Дизайн {this.getAvDes()}.");
        this.getScore();
    }
    
}