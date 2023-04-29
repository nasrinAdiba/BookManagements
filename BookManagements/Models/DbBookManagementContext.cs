using Microsoft.EntityFrameworkCore;

namespace BookManagements.Models
{
    public partial class DbBookManagementContext : DbContext
    {
        
            public DbBookManagementContext(DbContextOptions<DbBookManagementContext> options)
                : base(options)
            {
            }

            public virtual DbSet<book> Book { get; set; } = null!;



            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<book>(entity =>
                {
                    entity.ToTable("Book");

                    entity.Property(e => e.Id)
                    .HasColumnName("id");

                    entity.Property(e => e.BookName)
                        .HasMaxLength(250)
                        .HasColumnName("bookName");

                    entity.Property(e => e.PublisherName)
                        .HasMaxLength(250)
                        .HasColumnName("publisherName");

                    entity.Property(e => e.PublisherAge)
                        .HasMaxLength(200)
                        .HasColumnName("publisherAge");

                    entity.Property(e => e.PageNumber)
                        .HasMaxLength(200)
                        .HasColumnName("pageNumber");

                    entity.Property(e => e.PublishDate)
                        .HasMaxLength(200)
                        .HasColumnName("publishDate");
                    entity.Property(e => e.Type)
                        .HasMaxLength(200)
                        .HasColumnName("type");

                });




                OnModelCreatingPartial(modelBuilder);
            }
            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
    }
}
