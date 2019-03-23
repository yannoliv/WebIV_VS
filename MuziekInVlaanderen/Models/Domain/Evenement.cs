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
        public Plaats Locatie { get; set; }

        [Required]
        public string Beschrijving { get; set; }

        [Required]
        public DateTime Datum { get; set; }

        public Evenement(int id, string titel, Categorie categorie, Plaats locatie, string beschrijving, DateTime datum)
        {
            Id = id;
            Titel = titel;
            Categorie = categorie;
            Locatie = locatie;
            Beschrijving = beschrijving;
            Datum = datum;
        }

    }
}
