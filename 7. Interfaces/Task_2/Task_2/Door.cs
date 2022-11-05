internal sealed class Door : IPart
{
    bool isReady = false;
    public bool IsReady
    {
        get { return this.isReady; }
        set { this.isReady = value; }
    }
    public override string ToString()
    {
        return $"Двери " + (isReady == false ? "Не построено" : "Построено");
    }
}