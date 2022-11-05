internal sealed class Window : IPart
{
    bool isReady = false;
    static int number = 1;
    int id;
    public Window()
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
        return $"Окно {id} " + (isReady == false ? "Не построено" : "Построено");
    }
}
