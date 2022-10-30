internal class Quadratic_Equation
    {
    protected int a=0;
    protected int b=0;
    public int A
    {
        get { return a; }
        set { this.a = value; }
    }
    public int B
    {
        get { return b; }
        set { this.b = value; }
    }
    public static Quadratic_Equation Parse(string obj)
    {
        Quadratic_Equation equ = new Quadratic_Equation();
        string[] arr = obj.Split('x', '+', '=');
        equ.A = Convert.ToInt32(arr[0]);
        if (arr[1] != "")
        {
            equ.B = Convert.ToInt32(arr[1]);
        }
        else
            equ.B = Convert.ToInt32(arr[2]);

        return equ;
    } 
    }

