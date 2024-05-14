using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupCourtInfoL : IEntity
    {
        [Key]
        public int CourtinInfoId { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string CourtinInfo { get; set; }
        public int ProvinceId { get; set; }
        public virtual LookupProvinceL LookupProvinceL { get; set; }
        public virtual List<Case> Cases { get; set; }
    }
}

