

int[] arr = new int[10];

for(int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 15);
}

try
{
    for(int i = 0; i < arr.Length; i++)
    {
        try
        {
            if (arr[i] % 2 == 0)
                throw new MyExcept("Число четное");
            Console.WriteLine($"Индекс {i} - число {arr[i]}");
        }
        catch (MyExcept ex)
        {
            Console.WriteLine($"Индекс {i} - число {arr[i]} {ex.Message} Время {ex.TimeExcept}");
        }
    }
}
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine("Выход за границы массива");
    Console.WriteLine(ex.Message);
}