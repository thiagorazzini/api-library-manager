using LibraryManager.Core.Entities;
using LibraryManager.Core.Enums;

namespace LibraryManager.Application.Queries.Books
{
    public class GetBookByIdViewModel
    {
        public GetBookByIdViewModel(Book book)
        {
            Title = book.Title;
            Author = book.Author;
            ISBN = book.ISBN;
            PublicationYear = book.PublicationYear;
        }

        public string Title { get; private set; } = string.Empty!;
        public string Author { get; private set; } = string.Empty!;
        public string ISBN { get; private set; } = string.Empty!;
        public int PublicationYear { get; private set; }
    }
}
