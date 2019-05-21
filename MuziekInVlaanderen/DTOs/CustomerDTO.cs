using MuziekInVlaanderen.Models.Domain;
using System.Collections.Generic;

namespace MuziekInVlaanderen.DTOs
{
    public class CustomerDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public IEnumerable<Evenement> Evenementen { get; set; }

        public CustomerDTO() { }

        public CustomerDTO(Customer customer):this()
        {
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Email = customer.Email;
        }
    }
}
