using LibraryBLL;
using LibraryDAL;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* XMLClassWriters xMLClassWriters = new XMLClassWriters();
            xMLClassWriters.AuthorsWrite("Authors.xml", 3);
            xMLClassWriters.BooksWrite("Books.xml", 3);
            xMLClassWriters.ClientsWrite("Clients.xml", 3);
            xMLClassWriters.Co_AuthorWrite("Co_Authors.xml", 3);
            xMLClassWriters.GenresWrite("Genres.xml", 3);
            xMLClassWriters.SubscriptionsWrite("Subscriptions.xml", 3);*/
           XMLClassReader xMLClassReader = new XMLClassReader();
           var authors = xMLClassReader.AuthorReader("Authors.xml");
           foreach (var author in authors) { 
                Console.WriteLine(author.ToString());
            }

            var books = xMLClassReader.BookReader("Books.xml");
            foreach (var book in books) { 
                Console.WriteLine(book.ToString());     
            }
            var clients = xMLClassReader.ClientReader("Clients.xml");
            foreach (var client in clients)
            {
                Console.WriteLine(client.ToString());   
            }
            var co_authors = xMLClassReader.Co_AuthorReader("Co_Authors.xml");
            foreach (var co_author in co_authors)
            {
                Console.WriteLine(co_author.ToString());
            }

            var genres = xMLClassReader.GenreReader("Genres.xml");
            foreach(var genre in genres)
            {
                Console.WriteLine(genre.ToString());
            }

            var subscriptions = xMLClassReader.SubscriptionReader("Subscriptions.xml");
            foreach (var subscription in subscriptions)
            {
                Console.WriteLine(subscription.ToString());
            }
        }
    }
}