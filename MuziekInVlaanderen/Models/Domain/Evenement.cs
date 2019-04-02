using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Evenement
    {
        #region Properties

        public int Id { get; set; }

        [Required]
        public string Titel { get; set; }

        [Required]
        public string Beschrijving { get; set; }

        [Required]
        public List<Moment> Moment { get; set; }

        [Required]
        public Locatie Locatie { get; set; }

        [Required]
        public Categorie Categorie { get; set; }

        public Gallerij Gallerij { get; set; }

        [NotMapped]
        public List<String> SocialMedia { get; set; }
        
        public string SocialMediaString { get { return SocialMedia!=null?String.Join(',', SocialMedia):null; } set { if (value != null) { SocialMedia = value.Split(',').ToList(); } } }

        public string ProfielFoto { get; set; }

        public string OmslagFoto { get; set; }

        public double? Prijs { get; set; }


        #endregion

        #region Constructors

        private Evenement() { }

        public Evenement(string titel, string beschrijving, List<Moment> momenten, Locatie locatie, Categorie categorie)
            :this(titel, beschrijving, momenten, locatie, categorie, null,null,null,null,null)
        { }

        public Evenement(string titel, string beschrijving, List<Moment> momenten, Locatie locatie,  Categorie categorie, Gallerij gallerij, List<String> socialMedia, string profielFoto, string omslagFoto, double? prijs)
        {
            if (titel != null || titel.Length > 0)
                Titel = titel;
            else
                throw new ArgumentException("De titel mag niet leeg zijn.");

            if (beschrijving != null || beschrijving.Length > 0)
                Beschrijving = beschrijving;
            else
                throw new ArgumentException("De beschrijving mag niet leeg zijn.");

            if (momenten != null)
                Moment = momenten;

            if (locatie != null)
                Locatie = locatie;
            else
                throw new ArgumentException("De locatie mag niet leeg zijn.");
            
            Categorie = categorie;

            /* Properties die null mogen zijn */
            Gallerij = gallerij;
            SocialMedia = socialMedia;
            ProfielFoto = profielFoto;
            OmslagFoto = omslagFoto;
            Prijs = prijs;
        }

        #endregion

    }
}

/*

 public class evenement{

- titel: string
- descriptie: string
- datums Datum[]
- locatie: Locatie
- gallerij: Gallerij
- socialMedia: string[]
- profielFoto: string
- omslagFoto: string
- prijs: double

}


public class Datum{

- datum: Date
- BeginUur: TimeSpan
- EindUur: TimeSpan

}

public class Locatie{

- postcode: string
- straat: string
- gemeente: string

}

public class Gallerij{

- fotograaf: Fotograaf
- fotos: string[]

}

public class Fotograaf{

- naam: string
- afbeelding: string
- socialmedia: string[]

}
     
     
     */
