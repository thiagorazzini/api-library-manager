using LibraryManager.Core.Entities;

namespace LibraryManager.Core.Repositories
{
    public interface IBookRepository
    {
        Task AddNewBookAsync(Book book);
        Task UpdateBookAsync();
        Task<IEnumerable<Book>> GetBooksByNameAsync(string search);
        Task<Book?> GetBookByIdAsync(Guid id);
    }
}
