using LibraryManager.API.Enums;

namespace LibraryManager.API.Entities
{
    public class Book : BaseEntity
    {
        public Book(string title, string author, string iSBN, int publicationYear, int numberOfPage)
            : base()
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            PublicationYear = publicationYear;
            NumberOfPage = numberOfPage;
            Status = BookStatusEnum.Available;
        }

        public string Title { get; private set; } = string.Empty!;
        public string Author { get; private set; } = string.Empty!;
        public string ISBN { get; private set; } = string.Empty!;
        public int PublicationYear { get; private set; }
        public int NumberOfPage { get; private set; }
        public BookStatusEnum Status { get; private set; }
        public User? UserId { get; private set; }

        public void SellBook()
        {
            if (Status == BookStatusEnum.AvailableToSold)
            {
                Status = BookStatusEnum.Sold;
            }
        }

    }
}
