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
using MuziekInVlaanderen.Data;
using MuziekInVlaanderen.Models.Domain;

namespace MuziekInVlaanderen.Controllers
{
    public class EvenementenController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Evenementen
        public IQueryable<Evenement> GetEvenementen()
        {
            return db.Evenementen;
        }

        // GET: api/Evenementen/5
        [ResponseType(typeof(Evenement))]
        public async Task<IHttpActionResult> GetEvenement(int id)
        {
            Evenement evenement = await db.Evenementen.FindAsync(id);
            if (evenement == null)
            {
                return NotFound();
            }

            return Ok(evenement);
        }

        // PUT: api/Evenementen/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutEvenement(int id, Evenement evenement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != evenement.Id)
            {
                return BadRequest();
            }

            db.Entry(evenement).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EvenementExists(id))
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

        // POST: api/Evenementen
        [ResponseType(typeof(Evenement))]
        public async Task<IHttpActionResult> PostEvenement(Evenement evenement)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Evenementen.Add(evenement);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = evenement.Id }, evenement);
        }

        // DELETE: api/Evenementen/5
        [ResponseType(typeof(Evenement))]
        public async Task<IHttpActionResult> DeleteEvenement(int id)
        {
            Evenement evenement = await db.Evenementen.FindAsync(id);
            if (evenement == null)
            {
                return NotFound();
            }

            db.Evenementen.Remove(evenement);
            await db.SaveChangesAsync();

            return Ok(evenement);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EvenementExists(int id)
        {
            return db.Evenementen.Count(e => e.Id == id) > 0;
        }
    }
}