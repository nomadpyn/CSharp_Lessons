
using System.Collections.Immutable;

int[] array = new int[20];

Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(1,100);

Console.WriteLine("Готовый массив");

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Array.Sort(array);

Console.WriteLine("\nОтсортированный массив");
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

Console.WriteLine("\nСумма элементов " + array.Sum());
Console.WriteLine("Среднее арифметическое " + array.Average());

Array.Reverse(array);

Console.WriteLine("Вывод всех четных элементов массива в реверсивном массиве");
for(int i =0;i<array.Length; i++)
{
    if (array[i] % 2 == 0)
        Console.Write($"{array[i]} ");

}

Array.Clear(array);

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(1, 100);
Console.WriteLine("\nНовый массив");
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10)
       array[i] = (int)Math.Sqrt(array[i]);
    
}
Console.WriteLine("\nМассив в котором числа больше 10 заменены на свой корень");
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");