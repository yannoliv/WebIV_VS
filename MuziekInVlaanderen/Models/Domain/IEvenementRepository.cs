using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderen.Models.Domain
{
    public interface IEvenementRepository
    {
        void Add(Evenement e);
        void Delete(Evenement e);
        IEnumerable<Evenement> GetAll();
        Evenement GetBy(int id);
        void SaveChanges();
        bool TryGetEvenement(int id, out Evenement e);
        void Update(Evenement e);

    }
}
