using LibraryManager.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManager.Infra.Context
{
    public class LibraryContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowBook> BorrowBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("LibraryInMemoryDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar relacionamento BorrowBook -> User (muitos-para-um)
            modelBuilder.Entity<BorrowBook>()
                .HasOne(b => b.User)
                .WithMany(u => u.BorrowBook)
                .HasForeignKey(b => b.IdUser)
                .OnDelete(DeleteBehavior.Cascade); // Cascata para deletar empréstimos ao remover o usuário

            // Configurar relacionamento BorrowBook -> Book (muitos-para-um)
            modelBuilder.Entity<BorrowBook>()
                .HasOne(b => b.Book)
                .WithMany(bk => bk.BorrowBook)
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.Cascade); // Cascata para deletar empréstimos ao remover o livro

            // Opcional: definir a chave primária de BorrowBook, se necessário
            modelBuilder.Entity<BorrowBook>()
                .HasKey(b => b.Id);
        }

    }
}

