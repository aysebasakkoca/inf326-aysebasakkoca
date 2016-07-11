using System.Collections.Generic;

namespace Damacana.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string CreatedOn  { get; set; }  
        public decimal TotalPrice { get; set; }
        public virtual ICollection<User> UserId {get; set;} 
        public virtual ICollection<List<Product>> Products {get; set;} 


    }
}