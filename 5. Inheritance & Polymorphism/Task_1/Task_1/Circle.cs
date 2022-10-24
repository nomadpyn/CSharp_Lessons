namespace figures
{
    internal class Circle : GeomFig
    {
        private readonly double r;

        public Circle(double r)
        {
            this.r = r;
            this.GetP();
            this.GetS();
        }

        public override void GetP()
        {
            this.P = 2* Math.PI * this.r;
        }

        public override void GetS()
        {
            this.S = Math.PI * Math.Pow(this.r,2);
        }
        public override void Print()
        {
            Console.WriteLine("Круг с радиаусом {0:F}", this.r);
            Console.WriteLine("Периметр равен {0:F}. Площадь равна {1:F}\n", this.P, this.S);
        }

    }
}