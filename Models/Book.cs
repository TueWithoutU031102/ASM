using System;
using System.ComponentModel.DataAnnotations;

namespace ASM.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [Required]

        public string ISBN  { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [Range(1, 9999, ErrorMessage = "Category can not be blank")]
        public int CategoryId { get; set; }
       
        public Category Category { get; set; }
    }
}
