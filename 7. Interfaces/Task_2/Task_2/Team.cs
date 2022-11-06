internal class Team
{
    IWorker[] workers;
    Teamleader tl;
    public Team(uint amount_workers)
    {
       this.tl = new Teamleader();
        workers = new Worker[amount_workers];
       for(int i = 0; i < workers.Length; i++)
        {
            workers[i] = new Worker();
        } 
    } 
    public void Build(House Obj)
    {
       for(int i = 0; i < workers.Length; i++) {
            workers[i].Work(Obj);
        }
    }
    public void Report(House Obj)
    {
         tl.Work(Obj);
    }
}