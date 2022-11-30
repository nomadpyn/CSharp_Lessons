using System.Xml;
internal class XmlWorker
{

public static void createXml()
    {
        XmlTextWriter writer = null;

        try
        {
            writer = new XmlTextWriter("Order.xml", System.Text.Encoding.Unicode);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            writer.WriteStartElement("Order");
            writer.WriteStartElement("Order_Element");
            writer.WriteElementString("Name", "Молоко");
            writer.WriteElementString("Price", "65.4");
            writer.WriteElementString("Amount", "3");
            writer.WriteEndElement();
            writer.WriteStartElement("Order_Element");
            writer.WriteElementString("Name", "Хлеб");
            writer.WriteElementString("Price", "21.3");
            writer.WriteElementString("Amount", "1");
            writer.WriteEndElement();
            writer.WriteStartElement("Order_Element");
            writer.WriteElementString("Name", "Мясо");
            writer.WriteElementString("Price", "357.12");
            writer.WriteElementString("Amount", "3");
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (writer != null)
                writer.Close();
        }
    }
}  