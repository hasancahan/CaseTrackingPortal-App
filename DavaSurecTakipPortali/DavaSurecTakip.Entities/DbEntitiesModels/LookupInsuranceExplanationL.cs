using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupInsuranceExplanationL : IEntity
    {
        [Key]
        public int InsuranceExplanationId { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string InsuranceExplanation { get; set; }
        public virtual List<PaidDamages> PaidDamages { get; set; }
    }
}
