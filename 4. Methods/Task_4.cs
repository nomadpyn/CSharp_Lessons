
Russia.Capital Moscow = new Russia.Capital();
Japan.Capital Tokyo = new Japan.Capital();
France.Capital Paris = new France.Capital();

maxPopul(in Moscow, in Tokyo, in Paris);

static void maxPopul(in Russia.Capital R, in Japan.Capital J, in France.Capital F)
{
    Console.WriteLine("В программе есть три столицы, трех стран. Это:");
    R.print();
    J.print();
    F.print();

    double[] arr = { R.Popul_mil, J.Popul_mil, F.Popul_mil };

    Console.Write($"Больше всего людей {arr.Max()} живет в ");
    switch (Array.IndexOf(arr, arr.Max()))
    {
        case 0:
            {
                Console.WriteLine(R.Name);
                break;
            }
        case 1:
            {
                Console.WriteLine(J.Name);
                break;
            }
        case 2:
            {
                Console.WriteLine(F.Name);
                break;
            }
    }
}

namespace Russia
{
    public class Capital
    {
        private string name;
        private double popul_mil;

        public Capital() : this("Москва", 16.55) { }
        public Capital(string name, double popul_mil)
        {
            this.name = name;
            this.popul_mil = popul_mil;
        }

        public string Name { 
            get { return this.name; }
            set { this.name = value; }
        }
        public double Popul_mil {
            get { return this.popul_mil; }
            set { this.popul_mil = value; }
        }
        public void print()
        {
            Console.WriteLine($"{this.name}, население: {this.popul_mil} млн.");
        }
    }
}
namespace Japan
{
    public class Capital
    {
        private string name;
        private double popul_mil;

        public Capital() : this("Токио", 38.51) { }
        public Capital(string name, double popul_mil)
        {
            this.name = name;
            this.popul_mil = popul_mil;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Popul_mil
        {
            get { return this.popul_mil; }
            set { this.popul_mil = value; }
        }
        public void print()
        {
            Console.WriteLine($"{this.name}, население: {this.popul_mil} млн.");
        }
    }
}
namespace France
{
    public class Capital
    {
        private string name;
        private double popul_mil;

        public Capital() : this("Париж", 10.96) { }
        public Capital(string name, double popul_mil)
        {
            this.name = name;
            this.popul_mil = popul_mil;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public double Popul_mil
        {
            get { return this.popul_mil; }
            set { this.popul_mil = value; }
        }
        public void print()
        {
            Console.WriteLine($"{this.name}, население: {this.popul_mil} млн.");
        }
    }
}




