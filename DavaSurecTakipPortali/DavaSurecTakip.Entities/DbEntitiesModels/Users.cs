using DavaSurecTakip.Entities.DbEntitiesModels;
using DavaSurecTakip.Shared.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class Users:IEntity
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "Varchar(15)")]
        public string UserName { get; set; }

        [Column(TypeName = "Varchar(10)")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter uzunluğunda olmalıdır.")]
        public string UserPassword { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }



    }
}
