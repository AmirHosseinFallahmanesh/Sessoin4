using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomPropertyDemo
{
    public class Author
    {
        [Key]
        public int AutorCode { get; set; }

        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }
        public List<Book> Titles { get; set; } = new List<Book>();

       // public string FullName { get => FirstName + " " + LastName;  }

        [NotMapped]
        public string FullName { get; set; }
    }

}
