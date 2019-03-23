using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuziekInVlaanderen.Models.Domain
{
    public interface IEvenementRepository
    {
        Evenement GetBy(int id);
        bool TryGetEvenement(int id, out Evenement evenement);
        IEnumerable<Evenement> GetAll();
        void Add(Evenement evenement);
        void Delete(Evenement evenement);
        void Update(Evenement evenement);
        void SaveChanges();
    }
}