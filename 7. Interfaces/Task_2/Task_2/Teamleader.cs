internal sealed class Teamleader : IWorker
{
    public void Work(House Obj)
    {
        Console.WriteLine("Отчет о строительстве");
        for (int i = 0; i < Obj.HS.Length; i++)
        {
            if (Obj.HS[i].IsReady == false)
            {
                Console.WriteLine(Obj.HS[i]);
            }
            else
            {
                Console.WriteLine(Obj.HS[i]);
            }
        }
        Console.WriteLine();
    }
    public override string ToString()
    {
        return $"Бригадир";
    }
}