using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class Authority:IEntity
    {
        [Key]
        public int AuthId { get; set; }

        [Column(TypeName = "Varchar(40)")]
        public string AuthorityDefination { get; set; }

        [Column(TypeName = "Varchar(40)")]
        public string FieldName { get; set; }
        public bool View { get; set; }
        public bool Create { get; set; }
        public bool Change { get; set; }
        public bool Delete { get; set; }
    }
}
