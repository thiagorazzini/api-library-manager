using LibraryManager.Core.Enums;

namespace LibraryManager.Application.Models
{
    public class BookItemViewModel
    {
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
