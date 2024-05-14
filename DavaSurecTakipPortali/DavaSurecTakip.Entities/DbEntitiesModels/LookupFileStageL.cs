using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupFileStageL : IEntity
    {
        [Key]
        public int FileStageId { get; set; }

        [Column(TypeName = "Varchar(40)")]
        public string FileStage { get; set; }
        public virtual List<Case> Cases { get; set; }
    }
}
