
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());


try
{
    if (A % B != 0)
        throw new MyExcept("Не делится без остатка!");
    else
        Console.WriteLine("A делится на B без остатка");
}
catch(MyExcept My)
{
    Console.WriteLine(My.Message);
    Console.WriteLine(My.TimeExcept);
}
finally
{
    Console.WriteLine("Очистка ресурсов");
}