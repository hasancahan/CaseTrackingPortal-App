using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class LookupCaseSubjectL : IEntity
    {
        [Key]
        public int CaseSubjectId { get; set; }

        
        [Column(TypeName = "Varchar(100)")]
        public string CaseSubject { get; set; }
        public virtual List<Case> Cases { get; set; }
    }
}
