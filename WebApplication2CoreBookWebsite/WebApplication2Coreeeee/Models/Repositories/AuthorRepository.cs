using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2Coreeeee.Models.Repositories
{
    public class AuthorRepository : IBookStoreRepository<Author>
    {
        List<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>()
                {
                    new Author(){Id=11,FullName = "Ali Hatata"},
                    new Author(){Id=22,FullName = "AMR"}
                };
        }

        public void Add(Author entity)
        {
            authors.Add(entity);
        }

        public void Delete(int id)
        {
          var author =Find(id);
            authors.Remove(author);
        }

        public Author Find(int id)
        {
          var author = authors.SingleOrDefault(a => a.Id == id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
            var oldAuthor = Find(id);
            oldAuthor.FullName = newAuthor.FullName;
        }

    }
}
