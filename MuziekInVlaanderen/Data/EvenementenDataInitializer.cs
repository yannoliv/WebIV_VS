using MuziekInVlaanderen.Data;
using MuziekInVlaanderen.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuziekInVlaanderenAPI.Data
{
    public class EvenementenDataInitializer
    {

        private readonly ApplicationDbContext _dbContext;

        public EvenementenDataInitializer(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void InitializeData()
        {
            const string BESCHRIJVING = "Is at purse tried jokes china ready decay an. Small its shy way had woody downs power. To denoting admitted speaking learning my exercise so in. Procured shutters mr it feelings. To or three offer house begin taken am at. As dissuade cheerful overcame so of friendly he indulged unpacked. Alteration connection to so as collecting me. Difficult in delivered extensive at direction allowance. Alteration put use diminution can considered sentiments interested discretion. An seeing feebly stairs am branch income me unable.";

            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                var lijstEvenementen = new List<Evenement>() {
                new Evenement("Michael Bublé with the Classics",Categorie.Klassiek, Plaats.Aalst, BESCHRIJVING, new DateTime(2019,5,18)),
                new Evenement("Op de lijn met Pascal Cruque", Categorie.VoorDeHeleFamilie, Plaats.Brugge, BESCHRIJVING, new DateTime(2019, 9, 10)),
                new Evenement("De grote opera van Jaque DePicanté", Categorie.Klassiek, Plaats.Antwerpen, BESCHRIJVING, new DateTime(2020, 1, 12)),
                new Evenement("Zware Rock en Roll en Heavy Metal", Categorie.RockAndMetal, Plaats.Antwerpen, BESCHRIJVING, new DateTime(2019, 6, 9)),
                new Evenement("Pinto de Janero", Categorie.Pop, Plaats.Gent, BESCHRIJVING, new DateTime(2019, 6, 15)),
                new Evenement("Axel et le petit Trompet", Categorie.Klassiek, Plaats.Gent, BESCHRIJVING, new DateTime(2019, 8, 18))
            };
                _dbContext.Evenementen.AddRange(lijstEvenementen);
                _dbContext.SaveChanges();
            }
        }
    }
}
