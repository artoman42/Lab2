using Library;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace LibraryDAL
{
    public class XMLClassReader
    {
        public string path = "D:\\KPI\\.NET\\Lab2\\Library\\XMLDocs\\";
        public IEnumerable<Author> AuthorReader(string FileName) { 
            List<Author> authors = new List<Author>() { };
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path + FileName);
            XmlNode root = xmlDocument.DocumentElement;
     
            foreach(XmlNode node in root.ChildNodes)
            {
                int Id;
                string Name;
                bool success = int.TryParse(node.Attributes.GetNamedItem("Id").Value, out Id);
                Name = node.Attributes.GetNamedItem("Name").Value;
                if (success)
                {
                    authors.Add(new Author() { Id = Id, Name = Name });
                }
                else
                {
                    Console.WriteLine("Bad File !");
                }

                
            }
            
            return authors;
        }
        public IEnumerable<Book> BookReader(string FileName)
        {
            List<Book> Books = new List<Book>() { };
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path + FileName);
            XmlNode root = xmlDocument.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                int Id, GenreId = 0, Amount = 0;
                decimal CollateralValue = 0;
                string Name;
                bool success = int.TryParse(node.Attributes.GetNamedItem("Id").Value, out Id) 
                    && int.TryParse(node.Attributes.GetNamedItem("GenreId").Value, out GenreId)
                    && decimal.TryParse(node.Attributes.GetNamedItem("CollateralValue").Value, out CollateralValue)
                    && int.TryParse(node.Attributes.GetNamedItem("Amount").Value, out Amount);
                Name = node.Attributes.GetNamedItem("Name").Value;
                if (success)
                {
                    Books.Add(new Book() {
                        Id = Id,
                        Name = Name,
                        GenreId = GenreId,
                        CollateralValue = CollateralValue,
                        Amount = Amount });
                }
                else
                {
                    Console.WriteLine("Bad File !");
                }


            }

            return Books;
        }

        public IEnumerable<Client> ClientReader(string FileName)
        {
            List<Client> Clients = new List<Client>() { };
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path + FileName);
            XmlNode root = xmlDocument.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                int Id;
                string FullName, Adress, Phone, category;
                Library.enums.Categories Category =0;
                FullName = node.Attributes.GetNamedItem("FullName").Value;
                Adress = node.Attributes.GetNamedItem("Adress").Value;
                Phone = node.Attributes.GetNamedItem("Phone").Value;
                category = node.Attributes.GetNamedItem("Category").Value;
                bool success = int.TryParse(node.Attributes.GetNamedItem("Id").Value, out Id)
                    && Enum.TryParse(category, out Category);
                if (success)
                {
                    Clients.Add(new Client()
                    {
                        Id = Id,
                        FullName = FullName,
                        Adress = Adress,
                        Phone = Phone,
                        Category = Category

                    });
                }
                else
                {
                    Console.WriteLine("Bad File !");
                }

            }

            return Clients;
        }
        public IEnumerable<Co_Author> Co_AuthorReader(string FileName)
        {
            List<Co_Author> Co_Authors = new List<Co_Author>() { };
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path + FileName);
            XmlNode root = xmlDocument.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                int Id, BookId = 0, AuthorId = 0;
                bool success = int.TryParse(node.Attributes.GetNamedItem("Id").Value, out Id)
                    && int.TryParse(node.Attributes.GetNamedItem("BookId").Value, out BookId)
                    && int.TryParse(node.Attributes.GetNamedItem("AuthorId").Value, out AuthorId);
                if (success)
                {
                    Co_Authors.Add(new Co_Author()
                    {
                        Id = Id,
                        BookId = BookId,
                        AuthorId = AuthorId

                    });
                }
                else
                {
                    Console.WriteLine("Bad File !");
                }

            }

            return Co_Authors;
        }
        public IEnumerable<Genre> GenreReader(string FileName)
        {
            List<Genre> Genres = new List<Genre>() { };
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path + FileName);
            XmlNode root = xmlDocument.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                int Id;
                Library.enums.Genres Genre = 0;
                bool success = int.TryParse(node.Attributes.GetNamedItem("Id").Value, out Id)
                    && Enum.TryParse(node.Attributes.GetNamedItem("pGenre").Value, out Genre);
                if (success)
                {
                    Genres.Add(new Genre()
                    {
                        Id = Id,
                        pGenre = Genre

                    });
                }
                else
                {
                    Console.WriteLine("Bad File !");
                }

            }

            return Genres;
        }
        public IEnumerable<Subscription> SubscriptionReader(string FileName)
        {
            List<Subscription> Subscriptions = new List<Subscription>() { };
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path + FileName);
            XmlNode root = xmlDocument.DocumentElement;

            foreach (XmlNode node in root.ChildNodes)
            {
                int Id, ClientId = 0, BookId = 0;
                DateTime DateOfIssue = DateTime.MinValue, ExpectedReturnDate = DateTime.UtcNow;
                bool success = int.TryParse(node.Attributes.GetNamedItem("Id").Value, out Id)
                    && int.TryParse(node.Attributes.GetNamedItem("ClientId").Value, out ClientId)
                    && int.TryParse(node.Attributes.GetNamedItem("BookId").Value, out BookId)
                    && DateTime.TryParse(node.Attributes.GetNamedItem("DateOfIssue").Value, out DateOfIssue)
                    && DateTime.TryParse(node.Attributes.GetNamedItem("ExpectedReturnDate").Value, out ExpectedReturnDate);
                if (success)
                {
                    Subscriptions.Add(new Subscription()
                    {
                        Id = Id,
                        ClientId = ClientId,
                        BookId = BookId,
                        DateOfIssue = DateOfIssue,
                        ExpectedReturnDate = ExpectedReturnDate


                    });
                }
                else
                {
                    Console.WriteLine("Bad File !");
                }

            }

            return Subscriptions;
        }
    }
}