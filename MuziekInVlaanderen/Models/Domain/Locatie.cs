using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Locatie
    {
        public int Id { get; set; }

        public string Postcode { get; set; }
        public string Straat { get; set; }
        public string Gemeente { get; set; }

        public int EvenementId { get; set; }

        private Locatie() { }

        public Locatie(string postcode, string straat, string gemeente)
        {
            if(postcode != null || straat != null || gemeente != null)
            {
                Postcode = postcode;
                Straat = straat;
                Gemeente = gemeente;
            }
            else
            {
                throw new ArgumentException("Je mag geen lege postcode, straat of gemeente mee geven. ");
            }
        }
        
    }
}