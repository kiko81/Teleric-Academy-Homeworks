namespace TextToXML
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public static class TextToXML
    {
        private static void Main()
        {
            string name;
            string phone;
            string adress;

            using (StreamReader reader = new StreamReader("../../../person.txt"))
            {
                name = reader.ReadLine();
                adress = reader.ReadLine();
                phone = reader.ReadLine();
            }

            var personElement = new XElement(
                "person", 
                new XElement("name", name), 
                new XElement("address", adress), 
                new XElement("phone", phone));

            Console.WriteLine("person saved as person.xml");
            personElement.Save("../../../person.xml");
        }
    }
} 
