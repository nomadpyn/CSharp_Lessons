internal sealed class Worker : IWorker
{
    static uint number=1;
    uint id;
    public Worker()
    {
        id = number++;
    }
    public void Work(House Obj)
    {
        for (int i = 0; i < Obj.HS.Length; i++)
        {
            if (Obj.HS[i].IsReady == false)
            {
                Obj.HS[i].IsReady = true;
                break;
            }
        }
    }
    public override string ToString()
    {
        return $"Работник {id}";
    }
}