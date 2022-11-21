    internal class Calendar
    {
    public delegate void Del(Months now);
    public event Del? itsTime;
    public void monthCount()
    {
        for(Months i = Months.Январь; i<= Months.Декабрь; i++)
        {
            if ((byte)i % 3 == 0)
            {
                itsTime(i);
            }
        }
    }
    }