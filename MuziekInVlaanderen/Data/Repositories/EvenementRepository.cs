using Microsoft.EntityFrameworkCore;
using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuziekInVlaanderen.Data.Repositories
{
    public class EvenementRepository : IEvenementRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<Evenement> _evenementen;

        public EvenementRepository(ApplicationDbContext context)
        {
            this._context = context;
            this._evenementen = context.Evenementen;
        }

        public void Add(Evenement evenement)
        {
            this._evenementen.Add(evenement);
        }

        public void Delete(Evenement evenement)
        {
            this._evenementen.Remove(evenement);
        }

        public IEnumerable<Evenement> GetAll()
        {
            Console.Write(_evenementen);
            return this._evenementen.ToList();
        }

        public Evenement GetBy(int id)
        {
            return this._evenementen.FirstOrDefault(e => e.Id == id);
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public bool TryGetEvenement(int id, out Evenement evenement)
        {
            evenement = _context.Evenementen.Include(e => e.Locatie).Include(e => e.Categorie).FirstOrDefault(e => e.Id == id);
            return evenement != null;
        }

        public void Update(Evenement evenement)
        {
            this._evenementen.Update(evenement);
        }
    }
}