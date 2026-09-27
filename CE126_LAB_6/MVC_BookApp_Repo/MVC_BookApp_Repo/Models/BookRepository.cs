using MVC_BookApp_Repo.Models;

namespace MVC_BookApp_Repo.Models
{
    public class BookRepository : IBookRepository
    {
        private static List<Book> books = new List<Book>()
        {
            new Book { BookId = 1, Title = "C#", Author = "ABC", Category="Prog", Price=500, PublishedYear=2020 },
            new Book { BookId = 2, Title = "Java", Author = "XYZ", Category="Prog", Price=600, PublishedYear=2021 }
        };

        public List<Book> GetAll()
        {
            return books;
        }

        public Book GetById(int id)
        {
            return books.FirstOrDefault(b => b.BookId == id);
        }

        public void Add(Book book)
        {
            book.BookId = books.Count > 0 ? books.Max(b => b.BookId) + 1 : 1;
            books.Add(book);
        }

        public void Update(Book book)
        {
            var b = GetById(book.BookId);
            if (b != null)
            {
                b.Title = book.Title;
                b.Author = book.Author;
                b.Category = book.Category;
                b.Price = book.Price;
                b.PublishedYear = book.PublishedYear;
            }
        }

        public void Delete(int id)
        {
            var b = GetById(id);
            if (b != null)
                books.Remove(b);
        }
    }
}