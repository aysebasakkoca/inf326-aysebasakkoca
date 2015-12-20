using System.ComponentModel.DataAnnotations;

namespace DamacanaStore.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public dynamic Date { get; set; }
        public decimal TotalPrice { get; set; }
       
        // Foreign Key
        public int ProductId { get; set; }
        // Navigation property
        public Product Product { get; set; }
    }
}