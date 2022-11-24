
using System.Text;

string path = "int_test.dat";

int[] arr = {5, 7, 8, 34, 1, 54, 12, 36, 78, 12 };

SaveToFile(path, arr);
int[] arr2 = new int[7];
FromFileToArr(path, arr2);

foreach(int i in arr2)
{
    Console.Write($"{i} ");
}

void SaveToFile(string path, int[] arr)
{
    using(FileStream fs = new FileStream(path, FileMode.Create))
    {
        using(BinaryWriter bw = new BinaryWriter(fs, Encoding.Unicode))
        {
            Console.WriteLine($"Сохранение данных массива в файл {path}");
            foreach(int i in arr)
            {
                bw.Write(i);
            }
        }
    }
    Console.WriteLine("Данные успешно записаны");
}

void FromFileToArr(string path, int[] arr)
{
    Console.WriteLine($"Считываение файлов в массив длиной {arr.Length}");
    using(FileStream fs = new FileStream(path, FileMode.Open))
    {
        using (BinaryReader bw = new BinaryReader(fs, Encoding.Unicode))
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = bw.ReadInt32();
            }
        }
    }
    Console.WriteLine("Считывание прошло успешно");
}