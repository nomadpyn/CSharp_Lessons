    internal class Smartphone
    {
    string ? name;
    string ? color;
    uint year;
    public uint Year
    {
        get { return this.year; }
    }
    double price;
    public Smartphone(string name, string color, uint year, double price)
    {
        this.name = name;
        this.color = color;
        this.year = year;
        this.price = price;
    }
    public override string ToString()
    {
        return $"{this.name} {this.year} {this.color} - {this.price} Руб.";
    }
}