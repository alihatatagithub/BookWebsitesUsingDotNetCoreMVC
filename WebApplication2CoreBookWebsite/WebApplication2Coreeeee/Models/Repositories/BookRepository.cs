using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2Coreeeee.Models.Repositories
{
    public class BookRepository : IBookStoreRepository<Book>
    {
        List<Book> Books;
        public BookRepository()
        {
            Books = new List<Book>() { 
            new Book(){ Id = 1, Title = "C# Programming", Description = "No Desc" },
            new Book() { Id = 2, Title = "Java Programming", Description = "No Desc" },
            new Book { Id = 3, Title = "Python Programming", Description = "No Desc" },

            };
        }
        public void Add(Book entity)
        {
            Books.Add(entity);

        }

        public void Delete(int id)
        {
            var book=Find(id);
            Books.Remove(book);
        }

        public Book Find(int id)
        {
            var book = Books.Where(a => a.Id == id).FirstOrDefault();
            return book;
        }

        public IList<Book> List()
        {
            return Books;
        }

        public void Update(int id,Book newBook)
        {
            var oldbook = Find(id);
            oldbook.Title = newBook.Title;
            oldbook.Description = newBook.Description;
            oldbook.Author = newBook.Author;


        }
    }
}
