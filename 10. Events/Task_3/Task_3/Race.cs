using System.Reflection.Metadata.Ecma335;

public class Race
    {
    public delegate void raceDel(Car i, byte p);
    public event raceDel? Finish;
    List<Car> cars;
    byte place = 1;
    public Race(Car A, Car B, int distance)
    {
        cars = new List<Car> { A, B };
        for(int i = 0;i< cars.Count;i++)
        {
            cars[i].distToGo= distance;
        }
        this.Finish += raceFinish;
    }
    public void raceStart()
    {
        if (cars[0].CurrSpeed == 0 && cars[0].CurrSpeed == 0)
            Console.WriteLine("Гонка началась!");
    }
    private void raceFinish(Car i,byte p)
    {
        Console.WriteLine($"{i} финишировала {p}!");
    }
    public void race()
    {
        
        for (int i = 0; i < cars.Count; i++)
        {
            if (cars[i].distToGo >= 0)
            {
                Console.WriteLine(cars[i]);
                cars[i].addSpeed();
                cars[i].distToGo -= (int)cars[i].CurrSpeed;

                if (cars[i].distToGo <= 0)
                {
                    Finish(cars[i],place++);
                }
            }
        }
    }
    public bool isRace()
    {
        if (cars[0].distToGo <= 0 && cars[1].distToGo <= 0)
            return false;
        else
            return true;
    }
    public override string ToString()
    {
        return $"В гонке участвует {cars.Count} автомобилей\n{cars[0]}\n{cars[1]}";
    }
}