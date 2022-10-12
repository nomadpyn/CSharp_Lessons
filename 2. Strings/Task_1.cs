
Console.WriteLine("Введите имя");
string? name = Console.ReadLine();
Console.WriteLine("Введите фамилию");
string? sname = Console.ReadLine();
Console.WriteLine("Введите отчество");
string? oname = Console.ReadLine();

Console.WriteLine("Как вывести данные о пользователе?");
Console.WriteLine("1 - ФИО, 2 - ИФО, 3 - ФИ");

switch (Console.ReadKey().KeyChar)
    {
        case '1':
            {
                Console.WriteLine($"\n{sname} {name} {oname}");
                break;
            }
        case '2':
            {
                Console.WriteLine($"\n{name} {sname} {oname}");
                break;
            }
        case '3':
            {
                Console.WriteLine($"\n{sname} {name}");
                break;
            }
        default:
            {
                Console.WriteLine("Вы ничего не выбрали");
                break;
            }
 }


Console.WriteLine("\nВведите вторую фамилию");
string? sname_2 = Console.ReadLine();

if (sname.CompareTo(sname_2) == 0)
{
    Console.WriteLine($"Строки равны. Длина фамилии {sname.Length}");
}
else
{
    if (sname.CompareTo(sname_2) > 0)
    {
        Console.WriteLine($"Первая фамилия длиней второй {sname.Length} > {sname_2.Length}");
    }
    else
    {
        Console.WriteLine($"Вторая фамилия длиней первой {sname.Length} < {sname_2.Length}");
    }
}

