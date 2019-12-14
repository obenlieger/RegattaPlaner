﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegattaPlaner.Models
{
    public class Regatta
    {
        [Key]
        public virtual int RegattaId { get; set; }
        [Display(Name = "Regattaname")]
        public virtual string Name { get; set; }
        public virtual bool Choosen { get; set; }
        [Display(Name = "Von")]
        public virtual DateTime FromDate { get; set; }
        [Display(Name = "Bis")]
        public virtual DateTime ToDate { get; set; }
        [Display(Name = "Wassertiefe")]
        public virtual int Waterdepth { get; set; }
        [Display(Name = "Startbahnen")]
        public virtual int Startslots { get; set; }
        [Display(Name = "Meldung")]
        public virtual string ReportText { get; set; }
        [Display(Name = "Meldeeröffnung")]
        public virtual DateTime ReportOpening { get; set; }
        [Display(Name = "Meldetermin")]
        public virtual DateTime ReportSchedule { get; set; }
        [Display(Name = "Meldeanschrift")]
        public virtual string ReportAddress { get; set; }
        [Display(Name = "Telefon")]
        public virtual string ReportTel { get; set; }
        [Display(Name = "Fax")]
        public virtual string ReportFax { get; set; }
        [Display(Name = "E-Mail")]
        public virtual string ReportMail { get; set; }
        [Display(Name = "Kampfrichter")]
        public virtual string Judge { get; set; }
        [Display(Name = "Auszeichnungen")]
        public virtual string Awards { get; set; }
        [Display(Name = "Sicherheit")]
        public virtual string Security { get; set; }
        [Display(Name = "Zeitplan")]
        public virtual string ScheduleText { get; set; }
        [Display(Name = "Teilnehmergebühren")]
        public virtual float SubscriberFee { get; set; }
        [Display(Name = "Unterkunft")]
        public virtual string Accomodation { get; set; }
        [Display(Name = "Bemerkungen")]
        public virtual string Comment { get; set; }
        [Display(Name = "Verpflegung")]
        public virtual string Catering { get; set; }
        public virtual int ClubId { get; set; }
        [Display(Name = "Verein")]
        public virtual Club Club { get; set; }
        public virtual string Organizer { get; set; }
        public virtual int StartersLastYear { get; set; }
        public virtual string Category { get; set; }
        public virtual List<Startboat> Startboats { get; set; }
        public virtual List<Race> Races { get; set; }
        public virtual int WaterId { get; set; }
        public virtual Water Waters { get; set; }
        public virtual List<RegattaCampingFee> RegattaCampingFees { get; set; }
        public virtual List<RegattaStartingFee> RegattaStartingFees { get; set; }
        public virtual List<RegattaOldclass> RegattaOldclasses { get; set; }
        public virtual List<RegattaCompetition> RegattaCompetitions { get; set; }
        public virtual List<ReportedStartboat> ReportedStartboats { get; set; }
        public virtual List<RegattaClub> RegattaClubs { get; set; }
    }
}
