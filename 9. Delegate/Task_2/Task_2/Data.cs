internal class Data
{
    public void dataInt(int a)
    {
        for(int i=0;i< sizeof(int); i++)
        {
            Console.Write(a + "\t");
        }
        Console.WriteLine();
    }
    public void dataDouble(double a)
    {
        for (int i = 0; i < sizeof(double); i++)
        {
            Console.Write("{0:F3}\t",a);
        }
        Console.WriteLine();
    }
    public void dataDecimal(decimal a)
    {
        for (int i = 0; i < sizeof(decimal); i++)
        {
            Console.Write("{0:F3}\t", a);
        }
        Console.WriteLine();
    }
    public void dataChar(char a)
    {
        for (int i = 0; i < sizeof(char); i++)
        {
            Console.Write(a + "\t");
        }
        Console.WriteLine();
    }
    public void dataString(string a)
    {
        for (int i = 0; i < System.Text.ASCIIEncoding.Unicode.GetByteCount(a); i++)
        {
            Console.Write(a + "\t");
        }
        Console.WriteLine();
    }
}