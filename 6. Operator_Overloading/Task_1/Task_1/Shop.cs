 internal class Shop
    {
    string? name;
    string? adress;
    double square;

    public Shop(string nameP,string adressP, double squareP)
    {
        this.name = nameP;
        this.adress = adressP;
        this.square = squareP;
    }
    public override string ToString()
    {
        return $"Магазин \"{this.name}\" по адресу {this.adress}, площадью {this.square} кв.м.";
    }
}
