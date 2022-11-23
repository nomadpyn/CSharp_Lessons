
using System.Collections.Generic;
using System.Collections;

string[] arr = new string[10];

for (int i =0;i<arr.Length; i++)
{
    Console.WriteLine($"Введите слово {i+1} из {arr.Length}");
    arr[i] = Console.ReadLine();
}

IEnumerable<IGrouping<char, string>> query = from i in arr orderby i ascending group i by i[0] ;

foreach (IGrouping<char, string> key in query)
{
    Console.Write($"Key: {key.Key}\nValue:");
    foreach (string item in key)
    {
        Console.Write($"\t{item}");
    }
    Console.WriteLine();
}