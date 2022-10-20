using System;

namespace ASM.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuangtity { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
