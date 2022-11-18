using System.Transactions;

internal class Figure
    {
    public double X { get; set; }
    public Figure(double x)
    {
        this.X = x;
    }
    public double sqTriangle()
    {
        double h = Math.Pow(this.X, 2) - Math.Pow((this.X / 2), 2);
        return (this.X * (h / 2));
    }
    public double sqQuad()
    {
        return Math.Pow(this.X, 2);
    }
    public double sqCircle()
    {
        return (Math.PI * Math.Pow(this.X, 2));
    }
    }