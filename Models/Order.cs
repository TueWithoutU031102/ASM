using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ASM.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }    
        public DateTime OrderDate { get; set; }
        public string BookTitle { get; set; }
        public double Price { get; set; }
        public Book Book { get; set; }
    }
}
