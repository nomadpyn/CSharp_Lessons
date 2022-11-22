

Car F = new Car("Ferrari", 250, 35);
Car M = new Car("McLaren", 245, 35);

Race nw = new Race(F, M, 1500);

nw.raceStart();

while (nw.isRace())
{
    nw.race();
    Console.WriteLine();
    if (nw.isRace() == false) {
        Console.WriteLine("Гонка окончилась!");
    }
    //Console.ReadKey();
}