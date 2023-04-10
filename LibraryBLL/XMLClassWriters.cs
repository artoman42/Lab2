using System.Xml;

namespace LibraryBLL
{
    public class XMLClassWriters
    {
        public string path = "D:\\KPI\\.NET\\Lab2\\Library\\XMLDocs\\";
        public void AuthorsWrite(string FileName, int amount)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true; 
            using (XmlWriter xmlWriter = XmlWriter.Create(path + FileName, settings)) {
                string s;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Authors");
                for (int i = 0; i < amount; i++)
                {
                    xmlWriter.WriteStartElement("Author");
                    Console.WriteLine("Enter Author Id:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Id", s);
                    Console.WriteLine("Enter Author Name:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Name", s);
                    xmlWriter.WriteEndElement();

                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }

        }

        public void BooksWrite(string FileName, int amount) {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter xmlWriter = XmlWriter.Create(path + FileName, settings))
            {
                string s;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Books");
                for (int i = 0; i < amount; i++)
                {
                    xmlWriter.WriteStartElement("Book");
                    Console.WriteLine("Enter Book Id:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Id", s);
                    Console.WriteLine("Enter Book Name:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Name", s);
                    Console.WriteLine("Enter GenreId:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("GenreId", s);
                    Console.WriteLine("Enter Collateral Value:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("CollateralValue", s);
                    Console.WriteLine("Enter Amount:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Amount", s);

                    xmlWriter.WriteEndElement();

                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }


        }

        public void ClientsWrite(string FileName, int amount)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter xmlWriter = XmlWriter.Create(path + FileName, settings))
            {
                string s;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Clients");
                for (int i = 0; i < amount; i++)
                {
                    xmlWriter.WriteStartElement("Client");
                    Console.WriteLine("Enter Client Id:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Id", s);
                    Console.WriteLine("Enter Client Full Name:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("FullName", s);
                    Console.WriteLine("Enter Client Adress:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Adress", s);
                    Console.WriteLine("Enter Client Phone:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Phone", s);
                    Console.WriteLine("Enter Client Category:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Category", s);
                    xmlWriter.WriteEndElement();

                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }


        }
        public void Co_AuthorWrite(string FileName, int amount)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter xmlWriter = XmlWriter.Create(path + FileName, settings))
            {
                string s;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Сo_Authors");
                for (int i = 0; i < amount; i++)
                {
                    xmlWriter.WriteStartElement("Co_Author");
                    Console.WriteLine("Enter Сo_Author Id:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Id", s);
                    Console.WriteLine("Enter BookId:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("BookId", s);
                    Console.WriteLine("Enter AuthorId:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("AuthorId", s);

                    xmlWriter.WriteEndElement();

                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }

        }
        public void GenresWrite(string FileName, int amount)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter xmlWriter = XmlWriter.Create(path + FileName, settings))
            {
                string s;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Genres");
                for (int i = 0; i < amount; i++)
                {
                    xmlWriter.WriteStartElement("Genre");
                    Console.WriteLine("Enter Genre Id:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Id", s);
                    Console.WriteLine("Enter pGenre:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("pGenre", s);

                    xmlWriter.WriteEndElement();

                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }

        }

        public void SubscriptionsWrite(string FileName, int amount)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter xmlWriter = XmlWriter.Create(path + FileName, settings))
            {
                string s;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Subscriptions");
                for (int i = 0; i < amount; i++)
                {
                    xmlWriter.WriteStartElement("Subscription");
                    Console.WriteLine("Enter Subscription Id:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("Id", s);
                    Console.WriteLine("Enter ClientId:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("ClientId", s);
                    Console.WriteLine("Enter BookId:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("BookId", s);
                    Console.WriteLine("Enter DateOfIssue:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("DateOfIssue", s);
                    Console.WriteLine("Enter ExpectedReturnDate:");
                    s = Console.ReadLine();
                    xmlWriter.WriteAttributeString("ExpectedReturnDate", s);
                    xmlWriter.WriteEndElement();

                }
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
            }

        }

    }
}