using DavaSurecTakip.Shared.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupCaseResultL : IEntity
    {
        [Key]
        public int CaseResultId { get; set; }

        [Column(TypeName = "Varchar(100)")]
        //[Key]
        public string CaseResult { get; set; }
        public virtual List<Case> Cases { get; set; }
    }
}
