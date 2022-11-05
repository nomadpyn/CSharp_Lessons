internal sealed class Basement : IPart
{
    bool isReady = false;
    public bool IsReady
    {
        get { return this.isReady; }
        set { this.isReady = value; }
    }
    public override string ToString()
    {
        return $"Фундамент " + (isReady == false ? "Не построено" : "Построено");
    }
}