
show Message = () => Console.WriteLine("Будем складывать,вычитать и умножать Int");

Message();

doSomething Move = (int x, int y) => Console.WriteLine($"Сумма {x + y}");
Move+= (int x, int y) => Console.WriteLine($"Разность {x - y}");
Move += (int x, int y) => Console.WriteLine($"Произведение {x * y}");

Move(3, 5);

delegate void show();
delegate void doSomething(int x,int y);