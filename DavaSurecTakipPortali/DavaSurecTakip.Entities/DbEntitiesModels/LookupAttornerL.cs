using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupAttornerL : IEntity
    {
        [Key]
        public int AttornerId { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string Attorner { get; set; }
        //public int CaseId { get; set; }
        //public virtual Case Case { get; set; }
        //public virtual List<Case> Cases { get; set; }


       

    }
}
