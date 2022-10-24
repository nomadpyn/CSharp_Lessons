namespace figures
{
    internal class Triangle : GeomFig
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.GetP();
            this.GetS();
        }

        public override void GetP()
        {
            this.P = this.a + this.b + this.c;
        }

        public override void GetS()
        {
            double p = this.P / 2;
            double h = (2 * Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c))) / this.a;
            this.S = 0.5 * this.a * h;
        }
        public override void Print()
        {
            Console.WriteLine("Треугольник со сторонами {0:F}, {1:F} и {2:F}",this.a,this.b,this.c);
            Console.WriteLine("Периметр равен {0:F}. Площадь равна {1:F}\n", this.P, this.S);
        }

    }
}