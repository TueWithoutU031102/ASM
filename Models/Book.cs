using System;

namespace ASM.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public int ISBN  { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
    }
}
