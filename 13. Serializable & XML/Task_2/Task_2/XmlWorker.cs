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

public static void readXml()
    {
        XmlTextReader reader = null;
        try
        {
            reader = new XmlTextReader("Order.xml");
            reader.WhitespaceHandling = WhitespaceHandling.None;
            while (reader.Read())
            {
                if (reader.NodeType ==XmlNodeType.Element && reader.Name =="Name" )
                {
                   
                    Console.WriteLine("Наименование " + reader.ReadElementContentAsString());
                }
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Price")
                {

                    Console.WriteLine("Цена " + reader.ReadElementContentAsDouble() + " руб");
                }
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Amount")
                {

                    Console.WriteLine("Количество " + reader.ReadElementContentAsInt());
                }
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (reader != null)
                reader.Close();
        }

    }
}  