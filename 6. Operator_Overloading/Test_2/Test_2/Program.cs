
Quadratic_Equation nw = Quadratic_Equation.Parse(Console.ReadLine());

Console.WriteLine(nw);
Console.WriteLine(nw.getX()== 0 ? "Корней нет" : $"Корень линейного уравнения {nw.getX()}");
