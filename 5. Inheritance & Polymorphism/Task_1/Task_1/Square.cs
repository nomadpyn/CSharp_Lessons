namespace figures
{
    internal class Square : GeomFig
    {
        private readonly double a;
        

        public Square(double a)
        {
            this.a = a;
            this.GetP();
            this.GetS();
        }

        public override void GetP()
        {
            this.P = this.a*4;
        }

        public override void GetS()
        {
            this.S = Math.Pow(this.a,2);
        }
        public override void Print()
        {
            Console.WriteLine("Квадрат со стороной {0:F}", this.a);
            Console.WriteLine("Периметр равен {0:F}. Площадь равна {1:F}\n", this.P, this.S);
        }

    }
}