Count A = new Count();

A.onCount += Message;

A.getCount(12);

void Message(int a)
{
    Console.WriteLine($"Число {a} достигнуто успешно!");
}