using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DamacanaStore.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public dynamic Date { get; set; }
        public decimal TotalPrice { get; set; }

        // Foreign Key
        public int ProductId { get; set; }
        // Navigation property
        public virtual Product Product { get; set; }
       
       
        // Navigation property
    }
}