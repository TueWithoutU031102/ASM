using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace ASM.Models
{
    public class CartItem
    {
        public int quantity { set; get; }
        public Book book { set; get; }

    }
}
