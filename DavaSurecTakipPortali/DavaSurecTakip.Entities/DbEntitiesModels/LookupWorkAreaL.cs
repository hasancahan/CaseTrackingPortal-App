using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupWorkAreaL : IEntity
    {
        [Key]
        public int WorkAreaId { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string WorkArea { get; set; }
        public virtual List<PaidDamages> PaidDamages { get; set; }
    }
}
