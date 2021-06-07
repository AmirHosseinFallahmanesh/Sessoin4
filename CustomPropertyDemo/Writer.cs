using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomPropertyDemo
{
    [Table("Writer",Schema ="dbo")]
    public class Writer
    {
        public Writer()
        {
            WriterId = Guid.NewGuid();
        }
        public Guid WriterId { get; set; }
        public string LastName { get; set; }
        
    }

}
