using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Customer
    {
        #region Properties
        //add extra properties if needed
        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public ICollection<CustomerFavorite> Favorites { get; private set; }

        public IEnumerable<Evenement> FavoriteEvenementen => Favorites.Select(f => f.Evenement);
        #endregion

        #region Constructors
        public Customer()
        {
            Favorites = new List<CustomerFavorite>();
        }
        #endregion

        #region Methods
        public void AddFavoriteEvenement(Evenement evenement)
        {
            Favorites.Add(new CustomerFavorite() { EvenementId = evenement.Id, CustomerId = CustomerId, Evenement = evenement, Customer = this });
        }
        #endregion
    }
}
