

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

// создаем объект с конструктором с параметрами
PayBill A = new PayBill(14.2, 7, 5.6,4);
A.MakeBill();

writeFile(A);

Console.WriteLine(readFile());

PayBill.format = true;

writeFile(A);

Console.WriteLine(readFile());

// метод записи объекта в файл
static void writeFile(PayBill obj)
{
    BinaryFormatter binFormat = new BinaryFormatter();

    using (Stream fStream = File.Create("test.bin"))
    {
        binFormat.Serialize(fStream, obj);
    }
}

// метод чтения объекта из файла
static PayBill readFile()
{
    PayBill obj = null;
    BinaryFormatter binFormat = new BinaryFormatter();

    using (Stream fStream = File.OpenRead("test.bin"))
    {
        obj = (PayBill)binFormat.Deserialize(fStream);
    }

    return obj;
}