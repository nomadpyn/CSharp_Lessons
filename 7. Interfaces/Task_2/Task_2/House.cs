internal sealed class House
{
    IPart[] hs = {new Basement(), new Wall(), new Wall(), new Wall(), new Wall(), new Door(),
    new Window(),new Window(),new Window(),new Window(), new Roof()};
    public IPart[] HS
    {
        get { return hs; }
    }
    public bool this[int index]
    {
        get
        {
            if (index >= 0 && index < this.hs.Length)
                return this.hs[index].IsReady;
            throw new IndexOutOfRangeException();
        }
        set
        {
            this.hs[index].IsReady = value;
        }
    }
    public bool isHouseReady()
    {
        if (this.hs.Last().IsReady)
            return true;
        else
            return false;
    }
    public override string ToString()
    {
        string data = "";
        foreach(IPart item in hs)
        {
            data+= item.ToString()+"\n";
        }
        return data;
    }
}