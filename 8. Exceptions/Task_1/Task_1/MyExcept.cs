[Serializable]
public class MyExcept : Exception
{
	public DateTime TimeExcept { get; private set; }
	public MyExcept() : this("Ошибка") { TimeExcept = DateTime.Now; }
	public MyExcept(string message) : base(message) { TimeExcept = DateTime.Now; }
	public MyExcept(string message, Exception inner) : base(message, inner) { }
	protected MyExcept(
	  System.Runtime.Serialization.SerializationInfo info,
	  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}