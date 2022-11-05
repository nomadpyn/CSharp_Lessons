internal sealed class Wall : IPart
{
    bool isReady = false;
    static int number = 1;
    int id;
    public Wall()
    {
        id = number++;
    }
    public bool IsReady
    {
        get { return this.isReady; }
        set { this.isReady = value; }
    }
    public override string ToString()
    {
        return $"Стена {id} " + (isReady == false ? "Не построено" : "Построено");
    }
}