﻿using System;
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
        public IQueryable<Carte> GetCartes()
        {
            return db.Cartes;
        }
        [HttpGet]
        [Route("api/Cartes/Aletoir")]
        [ResponseType(typeof(List<CarteDTO>))]
        public IHttpActionResult GetDeckCartesAletoir()
        {
            List<Carte> list = db.Cartes.ToList();
            List<CarteDTO> listCarts = new List<CarteDTO>();
            Random rnd = new Random();
            int index = 0;
            while (listCarts.Count < 5)
            {

                index = rnd.Next(0, (list.Count - 1));
                Carte kart = list.ElementAt(index);

                CarteDTO c = new CarteDTO(kart.Id, kart.ValeurAttaque, kart.ValeurDefense, kart.prixAchat, kart.prixVendre);
                listCarts.Add(c);
            }

            return Ok(listCarts);
        }
        [HttpGet]
        [Route("api/Cartes/UsersCartes")]
        [ResponseType(typeof(List<CarteDTO>))]
        public IHttpActionResult GetCartesUserCourant()
        {

            ApplicationUser userr = CurrentUser;
            List<Carte> bancCart = db.Cartes.ToList();
            List<Carte> CartSelonId = new List<Carte>();
            List<CarteDTO> rez = new List<CarteDTO>();
            // List<CarteDTO> list = userr.Cartes.Select(a => new CarteDTO(a.Id,a.ValeurAttaque,a.ValeurDefense,a.prixAchat, a.prixVendre)).ToList();
            List<CarteJoueur> list = db.CarteJoueurs.Where(x => x.UserId == userr.Id).ToList();
            foreach( CarteJoueur c in list){

                CartSelonId.Add( bancCart.Where(x => x.Id == c.CarteId).First());   //Select(a => new CarteDTO(a.Id, a.ValeurAttaque, a.ValeurDefense, a.prixAchat, a.prixVendre)).ToList())
            }
           foreach (Carte kart in CartSelonId)
            {
                rez.Add(new CarteDTO(kart.Id, kart.ValeurAttaque, kart.ValeurDefense, kart.prixAchat, kart.prixVendre));
            }


            return Ok(rez);// list);
        }

        [HttpPost]
        [Route("api/Cartes/AddUsersCartes")]
        [ResponseType(typeof(List<CarteDTO>))]
        public IHttpActionResult AddCartesUserCourant(CarteDTO kart)
        {

            ApplicationUser userr = CurrentUser;

            db.CarteJoueurs.Add(new CarteJoueur(){CarteId = kart.id, UserId = userr.Id });
            db.SaveChanges();
            //  userr.Cartes.Add(new Carte {Id= kart.id, ValeurAttaque= kart.valeurAttaque, ValeurDefense = kart.valeurDefense, prixAchat = kart.prixAchat, prixVendre = kart.prixVendre });
            //  List<CarteDTO> list = userr.Cartes.Select(a => new CarteDTO(a.Id, a.ValeurAttaque, a.ValeurDefense, a.prixAchat, a.prixVendre)).ToList();
            return Ok(kart);
        }
        public ApplicationUser CurrentUser
        {
            get
            {

                var u = "20df3bf4-030c-47d8-b4b6-11146a6de086";// User.Identity.GetUserId(); /////POMENIAT!!!!!!!!!
                ApplicationUser rez = db.Users.Where(x => x.Id == u).First();   ////.Include("Cartes")

                return rez;
            }
        }

        // GET: api/Cartes/5
        [ResponseType(typeof(Carte))]
        public IHttpActionResult GetCarte(int id)
        {
            Carte carte = db.Cartes.Find(id);
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

            db.Cartes.Add(carte);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = carte.Id }, carte);
        }

        // DELETE: api/Cartes/5
        [ResponseType(typeof(Carte))]
        public IHttpActionResult DeleteCarte(int id)
        {
            Carte carte = db.Cartes.Find(id);
            if (carte == null)
            {
                return NotFound();
            }

            db.Cartes.Remove(carte);
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
            return db.Cartes.Count(e => e.Id == id) > 0;
        }
    }
}