[Serializable]
public class MyExcept : Exception
{
	public DateTime TimeExcept;
	public MyExcept() : this("Ошибка") { TimeExcept = DateTime.Now; }
	public MyExcept(string message) : base(message) { TimeExcept = DateTime.Now; }
	
}