

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

PayBill A = new PayBill(14.2, 7, 5.6, 4);
A.MakeBill();

writeFile(A);

Console.WriteLine(readFile());

PayBill.format = true;

writeFile(A);

Console.WriteLine(readFile());

static void writeFile(PayBill obj)
{
    BinaryFormatter binFormat = new BinaryFormatter();

    using (Stream fStream = File.Create("test.bin"))
    {
        binFormat.Serialize(fStream, obj);
    }
}

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