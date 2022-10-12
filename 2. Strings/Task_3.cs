
string? data = "прив41ет67друг12";

char[] arr = data.ToCharArray();

int size = 0;
int[] arr_i = new int[size+1];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= '1' && arr[i] <= '9')
    {
        arr_i[size] = (int)Char.GetNumericValue(arr[i]);
        size++;
        Array.Resize(ref arr_i, size+1);
    }
}

for (int i = 0; i < arr_i.Length; i++)
    Console.Write($"{arr_i[i]} ");

Console.WriteLine("\nСумма цифр в строке равна " + arr_i.Sum());
Console.WriteLine("Максимальное число равно " + arr_i.Max());

Console.WriteLine("Введите второе слово");
string? next = Console.ReadLine();

for(int i = 0; i < data.Length; i++)
{
    if (data.IndexOfAny(next.ToCharArray(), i, 1) != -1)
    {
        Console.WriteLine($"Символ {data[i]} есть во второй строке");
    }
    else
        Console.WriteLine($"Символ {data[i]} отсутствует во второй строке");

}