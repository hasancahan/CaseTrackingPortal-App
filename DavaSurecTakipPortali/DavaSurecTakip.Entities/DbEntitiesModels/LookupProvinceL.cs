using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupProvinceL : IEntity
    {
        [Key]
        public int ProvinceId { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string Province { get; set; }
        public virtual List<LookupLevyInfoL> LookupLevyInfoL { get; set; }
        public virtual List<LookupCourtInfoL> LookupCourtInfoL { get; set; }
        public virtual List<Case> Cases { get; set; }
    }
}
