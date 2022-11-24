
using System.Text;

string path = "test.txt";

WriteToFile(path);

GetDataInfo(path);

ReadFromFile(path);

void WriteToFile(string path)
{
    using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
    {
        using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
        {
            Console.WriteLine("Введите строку для записи в файл");
            string data = Console.ReadLine();
            foreach (char c in data)
            {
                sw.Write($"{c}_");
            }
            Console.WriteLine("Данные записаны\n");
        }

    }
}
void GetDataInfo(string path)
{
    FileInfo info = new FileInfo(path);

    if (info.Exists)
    {
        Console.WriteLine($"Имя файла: {info.Name}");
        Console.WriteLine($"Размер: {info.Length}");
        Console.WriteLine($"Расширение: {info.Extension}\n");
    }
}
void ReadFromFile(string path)
{
    using(FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
    {
        using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
        {
            Console.WriteLine("Данные из файла");
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}