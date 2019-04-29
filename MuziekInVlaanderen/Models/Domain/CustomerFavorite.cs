using System.ComponentModel.DataAnnotations;

namespace MuziekInVlaanderen.Models.Domain
{
    public class CustomerFavorite
    {
        #region Properties
        [Key]
        public int CustomerId { get; set; }

        public int EvenementId { get; set; }

        public Customer Customer { get; set; }

        public Evenement Evenement { get; set; }
        #endregion
    }
}
