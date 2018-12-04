using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using HeartStoneAPI.Models;

namespace HeartStoneAPI.Controllers
{
    public class CartesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Cartes
        public IQueryable<Carte> GetArtists()
        {
            return db.Artists;
        }

        // GET: api/Cartes/5
        [ResponseType(typeof(Carte))]
        public IHttpActionResult GetCarte(int id)
        {
            Carte carte = db.Artists.Find(id);
            if (carte == null)
            {
                return NotFound();
            }

            return Ok(carte);
        }

        // PUT: api/Cartes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCarte(int id, Carte carte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != carte.Id)
            {
                return BadRequest();
            }

            db.Entry(carte).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarteExists(id))
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

        // POST: api/Cartes
        [ResponseType(typeof(Carte))]
        public IHttpActionResult PostCarte(Carte carte)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Artists.Add(carte);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carte.Id }, carte);
        }

        // DELETE: api/Cartes/5
        [ResponseType(typeof(Carte))]
        public IHttpActionResult DeleteCarte(int id)
        {
            Carte carte = db.Artists.Find(id);
            if (carte == null)
            {
                return NotFound();
            }

            db.Artists.Remove(carte);
            db.SaveChanges();

            return Ok(carte);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarteExists(int id)
        {
            return db.Artists.Count(e => e.Id == id) > 0;
        }
    }
}