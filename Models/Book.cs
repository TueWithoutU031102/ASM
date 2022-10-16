using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASM.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public string ISBN  { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
    }
}
