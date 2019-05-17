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
        IEnumerable<Evenement> GetBy(string name = null, string categorie = null, string plaats = null);
        Evenement GetBy(int id);
        void SaveChanges();
        void Update(Evenement e);

    }
}
