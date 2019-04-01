using System;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Gallerij
    {

        public Fotograaf Fotograaf { get; set; }
        public string[] Fotos { get; set; }

        public Gallerij(Fotograaf fotograaf, string[] fotos)
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