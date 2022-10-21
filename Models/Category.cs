using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASM.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }
        public string CategoryDesription { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
