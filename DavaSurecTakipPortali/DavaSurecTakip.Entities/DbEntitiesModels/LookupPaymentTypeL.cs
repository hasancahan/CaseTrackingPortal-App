using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupPaymentTypeL:IEntity
    {
        [Key]
        public int PaymentTypeId { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string PaymentType { get; set; }
        public virtual List<PaidDamages> PaidDamages { get; set; }
    }
}
