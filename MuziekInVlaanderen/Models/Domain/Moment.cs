using System;
using System.ComponentModel.DataAnnotations;

namespace MuziekInVlaanderen.Models.Domain
{
    public class Moment
    {
        [Key]
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public TimeSpan BeginUur { get; set; }
        public TimeSpan EindUur { get; set; }

        public Moment(DateTime datum, TimeSpan beginUur, TimeSpan eindUur){
            if(datum != null && beginUur != null && eindUur != null)
            {
                this.Datum = datum;
                this.BeginUur = beginUur;
                this.EindUur = eindUur;
            }
            else
            {
                throw new ArgumentException("De data voor het moment is foutief ingevuld. ");
            }
        }

        private Moment() { }
    }
}