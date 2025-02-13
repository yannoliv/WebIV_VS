﻿using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<IdentityUser> _userManager;

        public EvenementenDataInitializer(ApplicationDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }


        public async Task InitializeDataAsync()
        {
            const String BESCHRIJVING = "Is at purse tried jokes china ready decay an. Small its shy way had woody downs power. To denoting admitted speaking learning my exercise so in. Procured shutters mr it feelings. To or three offer house begin taken am at. As dissuade cheerful overcame so of friendly he indulged unpacked. Alteration connection to so as collecting me. Difficult in delivered extensive at direction allowance. Alteration put use diminution can considered sentiments interested discretion. An seeing feebly stairs am branch income me unable.";

            _dbContext.Database.EnsureDeleted();
            if (_dbContext.Database.EnsureCreated())
            {
                //fotograaf
                var lisa = new Fotograaf("Lisa Oliviero", "profielfotolisa.png", new List<string>() { "twitter.be/lisa23", "facebook.nl/lisaolivero" });
                var robert = new Fotograaf("Robert Van Straeten", "profielfotorobert.png", new List<string>() { "twitter.be/robert", "facebook.nl/roberto" });


                // Evenementen aanmaken 
                var lijstEvenementen = new List<Evenement>() {

                    new Evenement("Olmenfeesten","Olmenfeesten = spel, feest, dans en eten. Er is de Olmenkwis, een afterwork, kindernamiddag, fietstocht, BBQ, kampvuur, fuif en optreden. En dat allemaal in de mooiste groene oase van Sint-Niklaas. Alle info en prijzen via www.olmenfeesten.be",
                        new List<Moment>{
                            new Moment(new DateTime(2019,10,12), new TimeSpan(6,30,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,10,13), new TimeSpan(5,0,0), new TimeSpan(11,0,0))}, 
                        new Locatie("9100", "lepenstraat 78c", "Sint-Niklaas"), Categorie.Acoustic,
                        new Gallerij(
                            lisa,
                            new List<string>(){ "kindernamiddagolmen.jpeg", "olmenfeesten3.png", "Achter-no-video.jpg", "olmenfeesten1.png",
                                "scoutsdolmen.png", "scoutsdolmen2.png" }
                        ),
                        new List<String>{"twitter.be/Olmenfeesten","Facebook.be/Scoutsdolmen"}
                        ,"profiel10.jpg","omslag10.jpg",null
                    ),

                    new Evenement("Stadsfestival kattepepper","Op zaterdag 4 mei van 15u tot 23u tijdens de Aalsterse Topdag, de grootste geanimeerde openluchthandelsdag van de stad Aalst . Livebands: van blues en rock over funk en soul tot de muziek van The Shadows en The Beatles. Met Shadowscoverband ‘Back in Time’, BissArt-ensemble, 18 Miles Down en My Friend The Atom.",
                        new List<Moment>{
                            new Moment(new DateTime(2020,1,14), new TimeSpan(6,0,0), new TimeSpan(9,30,0)),
                            new Moment(new DateTime(2020,1,15), new TimeSpan(6,0,0), new TimeSpan(10,30,0)),
                            new Moment(new DateTime(2020,1,16), new TimeSpan(6,0,0), new TimeSpan(10,30,0))}
                        , new Locatie("93200", "Werfplein", "Aalst"), Categorie.Rock,
                        new Gallerij(
                            robert,
                            new List<string>(){ "aalst-69.jpg", "kattepepermens.jpg", "Lavie-Ebbel-tijdens-Kattepeper-in-Aalst-Persregio-Dender.jpg"}
                        ),
                        new List<string>{"twitter.be","facebook.be"}
                        , "profiel1.jpg","omslag1.jpg",15.00
                    ),

                    new Evenement("Voerrock","Vierde editie van het Bertemse urban-familiefestival met zowel spetterende live optredens als chill- en speelzones voor jong en oud. Meer info op onze facebook of www.voerrock.be, met dank aan leiding en oud-leiding van Chiro Doeritsan. ",
                        new List<Moment>{
                            new Moment(new DateTime(2019,9,19), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,9,20), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,9,21), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,9,22), new TimeSpan(7,0,0), new TimeSpan(10,0,0))}
                        , new Locatie("3060", "Lange ZoutStraat", "Bertem"), Categorie.Rock,
                        new Gallerij(
                            robert,
                            new List<string>(){ "delikt-01.png" , "beatstreet-01.png", "Sunny-After-Moon-7.jpg"
                                ,"le77-01.png" , "Irie-Lion-14.jpg", "sunnyaftermoon-01.png"}
                            )
                       ,new List<string>{ "twitter.be/voerrock","facebook.be/voerrock19" }
                       ,"logoInkspot-web.png","omslag3.jpg",7.00
                    ),

                    new Evenement("D Festival ","D Festival is het jaarlijkse danstreffen waarvoor Théâtre des Tanneurs, Théâtre Marni en Le Senghor de handen in elkaar slaan. Het D-festival zet voortaan het avontuur voort in april, in het verlengde van de lentevakantie. Het spelterrein van D blijft evenwel trouw aan zichzelf: drie Brusselse cultuuroorden werken samen om, binnen het kader van een gedeelde dynamiek, ruimte te geven aan choreografen van wie het werk nauw aansluit bij wat er vandaag reilt en zeilt. Zo combineren de voorstellingen van deze editie vlijmscherpe sociale kritiek met de noodzaak om de wereld opnieuw in betovering te brengen. ",
                        new List<Moment>{
                            new Moment(new DateTime(2019,9,19), new TimeSpan(8,0,0), new TimeSpan(11,40,0))}
                        , new Locatie("9000", "Welleweg", "Gent"), Categorie.Nineties,
                        null,null,"profiel11.jpg","omslag11.jpg",20.00
                    ),

                    new Evenement("Official guitar day","Rhythm Naturals en De Centrale brengen met deze 7e editie van UAF opnieuw een gevarieerd jongerenprogramma. Op het programma staan een aantal cross-over danscreaties, de Vlaamse pre-selecties van de internationale End Of the Weak Belgium MC battle, workshops en enkele presentaties van cultureel ondernemerschap. Top of the bill is de finale van de MNM Urbanice Battle Of Talents. De 10 finalisten tonen op UAF het beste van zichzelf tijdens een live uitzending van MNM Urbanice vanuit De Centrale. ",
                        new List<Moment>{
                            new Moment(new DateTime(2019,11,8), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,11,9), new TimeSpan(7,0,0), new TimeSpan(10,30,0))}
                        , new Locatie("7100", "Halve Maatweg", "Brussel"), Categorie.Acoustic,
                        new Gallerij(
                            lisa,
                            new List<string>{ "acoustic1.jpg", "crossroads_guitar.jpg", "427540_rochehaut-panoramasurfrahan_c_wbt-sergematterne.jpg",
                            "jarrod_dickenson_and_atkins_guitars01_website_image_golw_standard.jpg","atkin_guitars22_website_image_golw_standard.jpg"}
                            ),
                        new List<string>{"twitter.be/guitarday","facebook.be/guitarday19"},
                        "profiel4.jpg","omslag4.jpg",10.00
                    ),

                    new Evenement("Niels De Stadsbaeter","Vorig jaar sloeg Niels voor het eerst de vleugels uit om voet te zetten buiten Tongeren, de bakermat van de klassieke muziek en de geboorteplaats van het festival. Zes dagen lang sloegen we onze tenten op in Genk, waar we de lokale bevolking aan het woord lieten en in een klassieke context aan de slag gingen met de multiculturele invloeden aldaar aanwezig. Een daverend succes dat schreeuwde om een vervolg. ",
                        new List<Moment>{
                            new Moment(new DateTime(2019,09,5), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,09,6), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,09,7), new TimeSpan(7,0,0), new TimeSpan(10,0,0)),
                            new Moment(new DateTime(2019,09,8), new TimeSpan(7,0,0), new TimeSpan(10,0,0))}
                        , new Locatie("6500", "Volksplein", "Antwerpen"), Categorie.Pop,
                        null,null,"profiel7.jpg","omslag7.jpg",null
                    ),
                    new Evenement("Disco REDBULL",BESCHRIJVING,
                        new List<Moment>{
                            new Moment(new DateTime(2019,10,19), new TimeSpan(9,0,0), new TimeSpan(10,0,0))}
                        , new Locatie("9300", "Italienweg", "Aalst"), Categorie.EMD,
                        null,null,
                        "profiel6.jpg","omslag6.jpg",6.00
                    )
                };
                _dbContext.Evenementen.AddRange(lijstEvenementen);
                _dbContext.SaveChanges();

                // Accounts maken
                Customer student = new Customer { Username = "web4",Email = "yann@gmail.com", FirstName = "Yannick", LastName = "Olivier" };
                _dbContext.Customers.Add(student);
                await CreateUser(student.Username ,student.Email, "gelukkiggeennetbeans");
                //meneer.AddFavoriteEvenement(_dbContext.Evenementen.First());
                _dbContext.SaveChanges();
            }
        }

        private async Task CreateUser(string username, string email, string password)
        {
            var user = new IdentityUser { UserName = username, Email = email };
            await _userManager.CreateAsync(user, password);
        }
    }
}
