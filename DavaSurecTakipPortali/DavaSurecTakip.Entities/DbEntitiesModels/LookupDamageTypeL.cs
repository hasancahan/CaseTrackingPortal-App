using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupDamageTypeL : IEntity
    {
        [Key]
        public int DamageTypeId { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string DamageType { get; set; }
        public virtual List<PaidDamages> PaidDamages { get; set; }
    }
}
