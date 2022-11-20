internal class Count
{
    public delegate void Contain(int a);
    public event Contain? onCount;
    public void getCount(int a)
    {
        for (int i = 0; i < 25; i++)
        {
            if (i == a)
            {
                onCount(a);
            }
        }
    }
}
