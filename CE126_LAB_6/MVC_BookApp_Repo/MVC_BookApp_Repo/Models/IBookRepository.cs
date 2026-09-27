using MVC_BookApp_Repo.Models;

namespace MVC_BookApp_Repo.Models
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);
    }
}