
using System.Collections.Specialized;
using System.Globalization;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

string path = ".";

getFilesInfo(path);

createFile(path, "test.bin");

readFile(path, "test.bin");

void getFilesInfo(string path)
{
    DirectoryInfo dir = new DirectoryInfo(path);

    FileInfo[] fi = dir.GetFiles();

    Console.WriteLine("Все файлы в директории");
    foreach (FileInfo i in fi)
    {
        Console.WriteLine($"{i.Name} - {i.Length} Байт");
    }
    Console.WriteLine();
}

void createFile(string path, string file)
{
    DirectoryInfo dir = new DirectoryInfo(path);

    FileInfo fi = new FileInfo(path + "\\" + file);

    if (fi.Exists)
    {
        Console.WriteLine("Файл \"test.bin\" уже существует");
    }
    else
    {
        using (FileStream fs = fi.Open(FileMode.Create, FileAccess.Write, FileShare.None))
        {

            Console.WriteLine("Введите данные для записи в файл");
            string data = Console.ReadLine();
            byte[] write = Encoding.Default.GetBytes(data);
            fs.Write(write, 0, write.Length);
            Console.WriteLine("Данные записаны\n");
        }
    }
}

void readFile(string path, string file)
{
    DirectoryInfo dir = new DirectoryInfo(path);

    FileInfo fi = new FileInfo(path + "\\" + file);

    if (fi.Exists)
    {
        using (FileStream fs = fi.OpenRead())
        {
            byte[] read = new byte[(int)fs.Length];
            fs.Read(read, 0, read.Length);
            string data = Encoding.Default.GetString(read);
            Console.WriteLine("Данные из файла:\n" + data + "\n");
        }
    }
    else
    {
        Console.WriteLine("Такого файла не существует:\n");
    }
}
