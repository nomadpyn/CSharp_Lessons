namespace figures
{
    internal class Rectangle : GeomFig
    {
        private readonly double a;
        private readonly double b;
       
        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
            this.GetP();
            this.GetS();
        }

        public override void GetP()
        {
            this.P = (this.a + this.b)*2;
        }

        public override void GetS()
        {
           this.S =  this.a * this.b;
        }
        public override void Print()
        {
            Console.WriteLine("Прямоугольник со сторонами {0:F} и {1:F}", this.a, this.b);
            Console.WriteLine("Периметр равен {0:F}. Площадь равна {1:F}\n", this.P, this.S);
        }

    }
}