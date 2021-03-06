// <auto-generated />
using System;
using CustomPropertyDemo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomPropertyDemo.Migrations
{
    [DbContext(typeof(SampleContext))]
    [Migration("20210607150121_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomPropertyDemo.Author", b =>
                {
                    b.Property<int>("AutorCode")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastName");

                    b.HasKey("AutorCode");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("CustomPropertyDemo.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorAutorCode");

                    b.Property<string>("Title");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorAutorCode");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("CustomPropertyDemo.Book", b =>
                {
                    b.HasOne("CustomPropertyDemo.Author", "Author")
                        .WithMany("Titles")
                        .HasForeignKey("AuthorAutorCode");
                });
#pragma warning restore 612, 618
        }
    }
}
