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
                    new Evenement("Michael Bublé with the Classics",BESCHRIJVING,
                        new Moment[]{
                            new Moment(new DateTime(2019,10,12), new TimeSpan(6,30,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,10,13), new TimeSpan(5,0,0), new TimeSpan(11,0,0))}
                        , new Locatie("6000", "Rionero", "Antwerpen"), Categorie.Classic
                    ),
                    new Evenement("Trevéro De la Casa",BESCHRIJVING,
                        new Moment[]{
                            new Moment(new DateTime(2020,1,14), new TimeSpan(6,0,0), new TimeSpan(9,30,0)),
                            new Moment(new DateTime(2020,1,15), new TimeSpan(6,0,0), new TimeSpan(10,30,0)),
                            new Moment(new DateTime(2020,1,16), new TimeSpan(6,0,0), new TimeSpan(10,30,0))}
                        , new Locatie("7000", "De gildeweg", "Brussel"), Categorie.Classic
                    ),
                    new Evenement("Punk Rock",BESCHRIJVING,
                        new Moment[]{
                            new Moment(new DateTime(2019,9,19), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,9,20), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,9,21), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,9,22), new TimeSpan(7,0,0), new TimeSpan(10,0,0))
}
                        , new Locatie("5500", "Lange ZoutStraat", "Gent"), Categorie.Rock
                    ),
                    new Evenement("New Wave 19",BESCHRIJVING,
                        new Moment[]{
                            new Moment(new DateTime(2019,9,19), new TimeSpan(8,0,0), new TimeSpan(11,40,0))}
                        , new Locatie("9000", "Welleweg", "Gent"), Categorie.EMD
                    ),
                    new Evenement("Slow guitar evening",BESCHRIJVING,
                        new Moment[]{
                            new Moment(new DateTime(2019,11,8), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,11,9), new TimeSpan(7,0,0), new TimeSpan(10,30,0))}
                        , new Locatie("7100", "Halve Maatweg", "Brussel"), Categorie.Acoustic
                    ),
                    new Evenement("The Beatles revamp",BESCHRIJVING,
                        new Moment[]{
                            new Moment(new DateTime(2019,09,5), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,09,6), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,09,7), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,09,8), new TimeSpan(7,0,0), new TimeSpan(10,0,0))}
                        , new Locatie("6500", "Volksplein", "Antwerpen"), Categorie.Nineties
                    ),
                    new Evenement("Skrillex dnb dubstep",BESCHRIJVING,
                        new Moment[]{
                            new Moment(new DateTime(2019,10,19), new TimeSpan(9,0,0), new TimeSpan(10,0,0))}
                        , new Locatie("9300", "Italienweg", "Aalst"), Categorie.EMD
                    )
                };
                _dbContext.Evenementen.AddRange(lijstEvenementen);
                _dbContext.SaveChanges();
            }
        }
    }
}
