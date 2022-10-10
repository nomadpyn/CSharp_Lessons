
int[][] arr = new int[5][];

for (int i = 0; i < 5; i++)
{
    Random rnd = new Random();
    arr[i] = new int[5];

    for(int y =0; y < 5; y++)
        arr[i][y] = rnd.Next(1,100);
       
}

for(int i=0;i<arr.Length; i++)
{
    for(int j=0; j<arr[i].Length; j++)
    {
        Console.Write($"{arr[i][j]}\t");
    }
    Console.Write("\n");
}
int[] arr_max = new int[5];

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Сумма элементов строки {i} = {arr[i].Sum()}");
    Console.WriteLine($"Максимальный элемент в строке {i} = {arr[i].Max()}");
    arr_max[i] = arr[i].Max();
}

Console.WriteLine($"Самый большой элемент в массиве {arr_max.Max()}");