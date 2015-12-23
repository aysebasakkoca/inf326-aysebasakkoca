using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DamacanaStore.Models;

namespace DamacanaStore.Controllers
{
    public class ShoppingCartsController : ApiController
    {
        private DamacanaStoreContext db = new DamacanaStoreContext();

        public IQueryable<ShoppingCart> GetShoppingCarts()
        {
            var ShoppingCarts = from b in db.ShoppingCarts
                        select new ShoppingCart()
                        {
                            Id = b.Id,
                        };

            return ShoppingCarts;
        }

        // GET api/Books/5
        [ResponseType(typeof(CartDetailDTO))]
        public async Task<IHttpActionResult> GetBook(int id)
        {
            var ShoppingCarts = await db.ShoppingCarts.Include(b => b.Id).Select(b =>
                new CartDetailDTO()
                {
                    Id = b.Id,
        
  
                }).SingleOrDefaultAsync(b => b.Id == id);
            if (ShoppingCarts == null)
            {
                return NotFound();
            }

            return Ok(ShoppingCarts);
        } 

        // PUT: api/ShoppingCarts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutShoppingCart(int id, ShoppingCart shoppingCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shoppingCart.Id)
            {
                return BadRequest();
            }

            db.Entry(shoppingCart).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShoppingCartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ShoppingCarts
        [ResponseType(typeof(ShoppingCart))]
        public async Task<IHttpActionResult> PostShoppingCart(ShoppingCart shoppingCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ShoppingCarts.Add(shoppingCart);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = shoppingCart.Id }, shoppingCart);
        }

        // DELETE: api/ShoppingCarts/5
        [ResponseType(typeof(ShoppingCart))]
        public async Task<IHttpActionResult> DeleteShoppingCart(int id)
        {
            ShoppingCart shoppingCart = await db.ShoppingCarts.FindAsync(id);
            if (shoppingCart == null)
            {
                return NotFound();
            }

            db.ShoppingCarts.Remove(shoppingCart);
            await db.SaveChangesAsync();

            return Ok(shoppingCart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ShoppingCartExists(int id)
        {
            return db.ShoppingCarts.Count(e => e.Id == id) > 0;
        }
    }
}