internal class Team
{
    IWorker[] workers;
    Teamleader tl;
    public Team(string name, uint amount_workers)
    {
       this.tl = new Teamleader();
        workers = new IWorker[amount_workers]; 
    } 
}