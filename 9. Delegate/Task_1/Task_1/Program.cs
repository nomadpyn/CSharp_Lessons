
Figure A = new Figure(3.2);

figSquare del = A.sqTriangle;
del += A.sqQuad;
del += A.sqCircle;

int i = 0;

foreach(figSquare item in del.GetInvocationList())
{
    Console.WriteLine("Squre of {0} is {1:F}", (Fig)i, item());
    i++;
}
enum Fig
{
    Triangle,
    Quad,
    Circle
};

delegate double figSquare();