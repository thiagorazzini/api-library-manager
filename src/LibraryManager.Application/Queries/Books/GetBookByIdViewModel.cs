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
            NumberOfPage = book.NumberOfPage;
            Status = book.Status;
            UserId = book.UserId?.Id;
        }

        public string Title { get; private set; } = string.Empty!;
        public string Author { get; private set; } = string.Empty!;
        public string ISBN { get; private set; } = string.Empty!;
        public int PublicationYear { get; private set; }
        public int NumberOfPage { get; private set; }
        public BookStatusEnum Status { get; private set; }
        public Guid? UserId { get; private set; }
    }
}
