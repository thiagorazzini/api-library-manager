using LibraryManager.API.Enums;

namespace LibraryManager.API.Models
{
    public class CreateBookInputModel
    {
        public string Title { get; set; } = string.Empty!;
        public string Author { get; set; } = string.Empty!;
        public string ISBN { get; set; } = string.Empty!;
        public int PublicationYear { get; set; }
        public int NumberOfPage { get; set; }
        public BookStatusEnum Status { get; set; }
        public Guid UserId { get; set; }
        public decimal Price { get; set; }
    }
}
