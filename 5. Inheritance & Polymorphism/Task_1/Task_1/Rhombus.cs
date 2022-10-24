namespace figures
{
    internal class Rhombus : GeomFig
    {
        private readonly double d1;
        private readonly double d2;
        private readonly double a;

        public Rhombus(double d1P, double d2P)
        {
            this.d1 = d1P;
            this.d2 = d2P;
            this.a = (Math.Sqrt(Math.Pow(this.d1, 2) + Math.Pow(this.d2, 2))) / 2;
            this.GetP();
            this.GetS();
        }

        public override void GetP()
        {
            this.P = this.a * 4;
        }

        public override void GetS()
        {
            this.S = 0.5 * this.d1 * this.d2;
        }
        public override void Print()
        {
            Console.WriteLine("Ромб со стороной {0:F}", this.a);
            Console.WriteLine("Периметр равен {0:F}. Площадь равна {1:F}\n", this.P, this.S);
        }

    }
}