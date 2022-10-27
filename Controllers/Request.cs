using ASM.Models;
using System;

namespace ASM.Controllers
{
    public class Request
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime RequestDate { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }

        public string Accepted { get; set; }
        public int BookID { get; set; }
        public Book book { get; set; }
    }
}
