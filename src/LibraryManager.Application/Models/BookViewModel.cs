using LibraryManager.Core.Enums;

namespace LibraryManager.Application.Models
{
    public class BookViewModel
    {
        public BookViewModel(Guid id, string title, string author, string iSBN, 
            int publicationYear, int numberOfPage, BookStatusEnum status, Guid userId)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = iSBN;
            PublicationYear = publicationYear;
            NumberOfPage = numberOfPage;
            Status = status;
            UserId = userId;
        }

        public Guid Id { get; private set; }
        public string Title { get; private set; } = string.Empty!;
        public string Author { get; private set; } = string.Empty!;
        public string ISBN { get; private set; } = string.Empty!;
        public int PublicationYear { get; private set; }
        public int NumberOfPage { get; private set; }
        public BookStatusEnum Status { get; private set; }
        public Guid UserId { get; private set; }
    }
}
