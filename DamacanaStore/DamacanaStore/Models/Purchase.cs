using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DamacanaStore.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public decimal TotalPrice { get; set; }

        public List<Product> PurchaseList { get; set; }
        // Foreign Key
        public virtual Product Product { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}