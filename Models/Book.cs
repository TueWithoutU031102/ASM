using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ASM.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [MinLength(10), MaxLength(10)]
        public string ISBN { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required(ErrorMessage = "Language can not be blank")]
        public string Language { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Url(ErrorMessage = "Image must be url")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Category can not be blank")]
        [Range(1, 9999)]
        public int CategoryId { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Price must from 0$ - 1000$")]
        public double Price { get; set; }

        public Category Category { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
