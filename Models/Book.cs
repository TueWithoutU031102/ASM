using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASM.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [MinLength(10),MaxLength(10)]
        public string ISBN  { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Url(ErrorMessage = "Image must be url")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Category can not be blank")]
        [Range(1, 9999)]
        public int CategoryId { get; set; }
        
        public Category Category { get; set; }
    }
}
