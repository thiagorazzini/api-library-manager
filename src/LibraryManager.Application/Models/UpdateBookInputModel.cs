namespace LibraryManager.Application.Models
{
    public class UpdateBookInputModel
    {
        public Guid BookId { get; set; }
        public string Title { get; set; } = string.Empty!;
        public string Author { get; set; } = string.Empty!;
        public string ISBN { get; set; } = string.Empty!;
        public int PublicationYear { get; set; }
        public int NumberOfPage { get; set; }
        public decimal Price { get; set; }
    }
}
