using System;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Locatie
    {
        public string Postcode { get; set; }
        public string Straat { get; set; }
        public string Gemeente { get; set; }

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