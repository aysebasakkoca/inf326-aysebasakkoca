using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Damacana.Controllers;
using Damacana.Models;

namespace Damacana.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public virtual ICollection <User> UserId {get; set;} 
        public virtual ICollection<List<Product>> Products {get; set;} 

       
    }
}


