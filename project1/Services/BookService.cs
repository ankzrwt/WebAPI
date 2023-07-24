using project1.Model;

namespace project1.Services
{
    public class BookService
    {

        private CreateBookData data = CreateBookData.instance;

        public List<Book> getAll()
        {
            return data.books;
        }

        public Book getBookId(int Id)
        {
            for(int i = 0; i < data.books.Count; i++)
            {
                if (data.books[i].Id == Id)
                {
                    return data.books[i];
                }

            }
            return null;
        }
    }
}
