using System.Collections.Generic;

namespace ASM.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
