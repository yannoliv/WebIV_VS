using System;
using System.ComponentModel.DataAnnotations;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Evenement
    {
        #region Properties
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titel { get; set; }

        [Required]
        public string Beschrijving { get; set; }

        [Required]
        public Moment[] Moment { get; set; }

        [Required]
        public Locatie Locatie { get; set; }

        [Required]
        public Categorie Categorie { get; set; }

        public Gallerij Gallerij { get; set; }

        public string[] SocialMedia { get; set; }

        public string ProfielFoto { get; set; }

        public string OmslagFoto { get; set; }

        public double? Prijs { get; set; }


        #endregion

        #region Constructors

        public Evenement(string titel, string beschrijving, Moment[] momenten, Locatie locatie, Categorie categorie)
            :this(titel, beschrijving, momenten, locatie, categorie, null,null,null,null,null)
        { }

        public Evenement(string titel, string beschrijving, Moment[] momenten, Locatie locatie,  Categorie categorie, Gallerij gallerij, string[] socialMedia, string profielFoto, string omslagFoto, double? prijs)
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
