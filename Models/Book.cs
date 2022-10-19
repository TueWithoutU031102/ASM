using System;
using System.ComponentModel.DataAnnotations;

namespace ASM.Models
{
    public class Book
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [MinLength(10),MaxLength(10)]
        [Display(Name = "International Standard Book Number")]
        public string ISBN  { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Author { get; set; }
        [Url(ErrorMessage ="Image must be url")]
        public string Image { get; set; }
        [Range(1, 9999, ErrorMessage = "Category can not be blank")]
        public int CategoryId { get; set; }
       
        public Category Category { get; set; }
    }
}
