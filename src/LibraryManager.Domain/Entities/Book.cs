using LibraryManager.Core.Enums;

namespace LibraryManager.Core.Entities
{
    public class Book
    {
        public Book(Guid id, string title, string author, string iSBN, int publicationYear)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = iSBN;
            PublicationYear = publicationYear;
        }
        public Guid Id { get; private set; }
        public string Title { get; private set; } = string.Empty!;
        public string Author { get; private set; } = string.Empty!;
        public string ISBN { get; private set; } = string.Empty!;
        public int PublicationYear { get; private set; }

        public ICollection<BorrowBook> BorrowBook { get; private set; }

    }
}
