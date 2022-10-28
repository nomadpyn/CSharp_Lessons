using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

internal class Shop
    {
    private string? name;
    private string? adress;
    private double square;

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
    public string? Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string? Adress
    {
        get { return this.adress; }
        set { this.adress = value; }
    }
    public double Square
    {
        get { return this.square; }
        set { this.square = value == 0 ? 1 : value; }
    }
    public static Shop operator + (Shop obj, double sq)
    {
        obj.square += sq;
        return obj;
    }
    public static Shop operator -(Shop obj, double sq)
    {
        if (obj.square > sq+1)
        {
            obj.square -= sq;
        }
        
        return obj;
    }
    public static bool operator == (Shop obj1, Shop obj2)
    {
        if (obj1.square == obj2.square)
            return true;
        else
            return false;
    }
    public static bool operator !=(Shop obj1, Shop obj2)
    {
        if (obj1.square != obj2.square)
            return true;
        else
            return false;
    }
    public static bool operator <(Shop obj1, Shop obj2) {
        if (obj1.square < obj2.square)
            return true;
        else
            return false;
    }
    public static bool operator >(Shop obj1, Shop obj2)
    {
        if (obj1.square > obj2.square)
            return true;
        else
            return false;
    }
}
