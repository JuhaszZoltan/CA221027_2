using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CA221027_2
{
    internal class BookShelf
    {
        private static Random rnd = new();

        private List<Book> books = new();

        public float TotalPrice => books.Sum(x => x.Price);
        public int Count => books.Count;

        public List<Book> SearchByAuthor(string author)
            => books.FindAll(x => x.Author == author);

        public string[] AllAuthor =>
            books.Select(x => x.Author).Distinct().OrderBy(x => x).ToArray();

        public void Add(Book book)
        {
            if (book == null)
                throw new Exception("error");
            if (books.Contains(book))
                throw new Exception("error");
            books.Add(book);
        }

        public BookShelf RandomInit(int count)
        {
            for (int i = 0; i < count; i++)
            {
                books.Add(new Book()
                {
                    Author = "TODO",
                    Title = "TODO",
                    YearOfPublication = rnd.Next(1910, DateTime.Today.Year + 1),
                    Price = rnd.Next(3000) * 5,
                    Genre = (Genre)rnd.Next(Enum.GetNames(typeof(Genre)).Length),
                });
            }


            throw new NotImplementedException();
        }
        
    }
}
