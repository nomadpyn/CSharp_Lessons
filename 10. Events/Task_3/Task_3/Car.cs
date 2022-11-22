    public class Car
    {
    public delegate void carDel(uint speed);
    public event carDel? ItMaxSpeed;
    public string Name { get; set;}
    public uint MaxSpeed { get; set; }
    public uint CurrSpeed { get; set; }
    public uint Racing { get; set; }
    public int distToGo { get; set; }
    public Car(string name, uint maxSpeed, uint racing)
    {
        this.Name = name;
        this.MaxSpeed = maxSpeed;
        this.Racing= racing;
        ItMaxSpeed += itSpeed;
    }
    public void addSpeed()
    {
        uint add = 0;
        if (this.CurrSpeed <= (this.MaxSpeed- this.Racing))
        {
            add = (uint)new Random().Next((int)this.Racing);
            this.CurrSpeed += add;
            if (this.CurrSpeed >= 100&& this.CurrSpeed<=(100+add))
                ItMaxSpeed(100);
            if (this.CurrSpeed >= 200 && this.CurrSpeed <= (200 + add))
                ItMaxSpeed(200);

        }
    }
    private void itSpeed(uint speed)
    {
        Console.WriteLine($"{this.Name} достиг скорости в {speed}");
    }
    

    public override string ToString()
    {
        if (this.CurrSpeed == 0)
        {
            return $"Автомобиль {this.Name}"; 
        }
        else
        {
            return $"Автомобиль {this.Name} едет со скоростью {this.CurrSpeed}";
        }
    }
}