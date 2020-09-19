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
using AgendaContactos.Models;

namespace AgendaContactos.Controllers
{
    public class SivilasController : ApiController
    {
        private DattaContext db = new DattaContext();

        // GET: api/Sivilas
        public IQueryable<Sivila> GetSivilas()
        {
            return db.Sivilas;
        }

        // GET: api/Sivilas/5
        [ResponseType(typeof(Sivila))]
        public IHttpActionResult GetSivila(int id)
        {
            Sivila sivila = db.Sivilas.Find(id);
            if (sivila == null)
            {
                return NotFound();
            }

            return Ok(sivila);
        }

        // PUT: api/Sivilas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSivila(int id, Sivila sivila)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sivila.SivilaID)
            {
                return BadRequest();
            }

            db.Entry(sivila).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SivilaExists(id))
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

        // POST: api/Sivilas
        [ResponseType(typeof(Sivila))]
        public IHttpActionResult PostSivila(Sivila sivila)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sivilas.Add(sivila);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sivila.SivilaID }, sivila);
        }

        // DELETE: api/Sivilas/5
        [ResponseType(typeof(Sivila))]
        public IHttpActionResult DeleteSivila(int id)
        {
            Sivila sivila = db.Sivilas.Find(id);
            if (sivila == null)
            {
                return NotFound();
            }

            db.Sivilas.Remove(sivila);
            db.SaveChanges();

            return Ok(sivila);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SivilaExists(int id)
        {
            return db.Sivilas.Count(e => e.SivilaID == id) > 0;
        }
    }
}