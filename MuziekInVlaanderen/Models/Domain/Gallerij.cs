using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Gallerij
    {
        public int Id { get; set; }
       
        public Fotograaf Fotograaf { get; set; }

        [NotMapped]
        public List<String> Fotos { get; set; }

        public string FotosString { get { return Fotos != null ? String.Join(',', Fotos) : null; } set { if (value != null) { Fotos = value.Split(',').ToList(); } } }

        public int EvenementId { get; set; }

        private Gallerij() { }

        public Gallerij(Fotograaf fotograaf, List<String> fotos)
        {
            Fotograaf = fotograaf;
            if (fotos != null)
            {
                Fotos = fotos;
            }
            else
            {
                throw new ArgumentException("De fotos mogen niet leeg zijn als je een gallerij aanmaakt.");
            }
        }

    }
}