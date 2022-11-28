using System.Text.RegularExpressions;

Console.WriteLine("Введите номер телефона");

checkPhoneNumber(Console.ReadLine());


static void checkPhoneNumber(string data)
{
    Regex regex = new Regex(@"(8){1}-[0-9]{3}-[0-9]{3}-[0-9]{2}-[0-9]{2}");

    if (regex.IsMatch(data))
    {
        Console.WriteLine("Номер записан правильно");
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}