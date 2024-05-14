using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupLevyInfoL : IEntity
    {
        [Key]
        public int LevyInfoId { get; set; }

        [Column(TypeName = "Varchar(160)")]
        public string LevyInfo { get; set; }
        public int ProvinceId { get; set; }
        public virtual LookupProvinceL LookupProvinceL { get; set; }
        public virtual List<PaidDamages> PaidDamages { get; set; }
    }
}
