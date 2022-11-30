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
            ConsoleKey choise = ConsoleKey.Enter;
            do
            {
                Console.WriteLine("\nEnter - добавить элемент в заказ, End - закончить формирование заказа");
                choise = Console.ReadKey().Key;
                if (choise== ConsoleKey.Enter)
                {
                    writer.WriteStartElement("Order_Element");
                    Console.WriteLine("Введите наименование товара");
                    writer.WriteElementString("Name", Console.ReadLine());
                    Console.WriteLine("Введите цену товара");
                    writer.WriteElementString("Price", Console.ReadLine());
                    Console.WriteLine("Введите количество товара");
                    writer.WriteElementString("Amount", Console.ReadLine());
                    writer.WriteEndElement();
                }
            } while (choise != ConsoleKey.End);
           
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
            Console.WriteLine("\nСостав заказа:\n");
            while (reader.Read())
            {
                if (reader.NodeType ==XmlNodeType.Element && reader.Name =="Name" )
                {
                   
                    Console.WriteLine("Наименование: " + reader.ReadElementContentAsString());
                }
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Price")
                {

                    Console.Write("Цена: " + reader.ReadElementContentAsDouble() + " руб");
                }
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Amount")
                {

                    Console.Write(" Количество: " + reader.ReadElementContentAsInt()+"\n");
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