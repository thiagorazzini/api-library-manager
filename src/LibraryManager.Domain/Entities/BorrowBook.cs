namespace LibraryManager.Core.Entities
{
    public class BorrowBook
    {
        public Guid Id { get; private set; }
        
        public Guid IdUser { get; private set; }
        public User User { get; private set; }

        public Guid BookId { get; private set; }
        public Book Book { get; set; }

        public DateTime BorrowDate { get; private set; }
        public DateTime ReturnDate { get; private set; }
    }
}
