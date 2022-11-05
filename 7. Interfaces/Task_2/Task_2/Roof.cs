internal sealed class Roof : IPart
{
    bool isReady = false;
    public bool IsReady
    {
        get { return this.isReady; }
        set { this.isReady = value; }
    }
    public override string ToString()
    {
        return $"Крыша " + (isReady == false ? "Не построено" : "Построено");
    }
}