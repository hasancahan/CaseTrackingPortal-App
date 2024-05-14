using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupFileDamageStatusL : IEntity
    {
        [Key]
        public int DamageStatusId { get; set; }

        [Column(TypeName = "Varchar(40)")]
        public string FileDamagesStatus { get; set; }
        public virtual List<PaidDamages> PaidDamages { get; set; }
    }
}
