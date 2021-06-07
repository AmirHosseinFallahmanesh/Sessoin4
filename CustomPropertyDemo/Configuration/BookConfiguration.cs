using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomPropertyDemo.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(a => a.Title).HasColumnName("BookName");
            builder.Property(a => a.Title).HasColumnType("nvarchar")
                .HasMaxLength(20);

        }
    }
}
