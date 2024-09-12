using LibraryManager.Core.Enums;

namespace LibraryManager.Core.Entities
{
    public class User
    {
        public User(Guid id, string fullName, string email)
        {
            Id = id;
            FullName = fullName;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;

        public ICollection<BorrowBook> BorrowBook { get; private set; }

    }
}
