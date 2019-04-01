namespace MuziekInVlaanderen.Models.Domain
{
    public class Fotograaf
    {
        public string Naam { get; set; }
        public string ProfielFoto { get; set; }
        public string[] SocialMedia { get; set; }

        public Fotograaf(string naam, string profielFoto, string[] socialMedia)
        {
            if (naam != null)
                Naam = naam;
            ProfielFoto = profielFoto;
            SocialMedia = socialMedia;
        }
    }
}