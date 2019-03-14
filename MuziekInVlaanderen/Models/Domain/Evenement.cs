using System;
using System.ComponentModel.DataAnnotations;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Evenement
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titel { get; set; }

        [Required]
        public Categorie Categorie { get; set; }

        [Required]
        public Locatie Locatie { get; set; }

        [Required]
        public string Beschrijving { get; set; }

        [Required]
        public DateTime Datum { get; set; }
    }
}
