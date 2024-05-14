using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class UserAuthorization : IEntity
    {
        [Key]
        [Column(TypeName = "Varchar(40)")]
        public string AdName { get; set; }
        //[Key]
        public int AuthId { get; set; }
        //[Key]
        public int RowNumb { get; set; }

    }
}
