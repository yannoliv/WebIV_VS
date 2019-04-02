using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Fotograaf
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string ProfielFoto { get; set; }

        [NotMapped]
        public List<String> SocialMedia { get; set; }

        public string SocialMediaString { get { return SocialMedia != null ? String.Join(',', SocialMedia) : null; } set { if (value != null) { SocialMedia = value.Split(',').ToList(); } } }

        public Fotograaf(string naam, string profielFoto, List<String> socialMedia)
        {
            if (naam != null)
                Naam = naam;
            ProfielFoto = profielFoto;
            SocialMedia = socialMedia;
        }

        private Fotograaf()
        {

        }
    }
}