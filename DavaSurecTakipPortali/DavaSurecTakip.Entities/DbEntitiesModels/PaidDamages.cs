using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class PaidDamages:IEntity
    {

        [Key]
        public int RowNumb { get; set; }

        //_______________________________________________________________İlişkiler Oluşturuldu...
        public int CaseId { get; set; }
        public virtual Case Case { get; set; }
        public int PaymentTypeId { get; set; }
        public virtual LookupPaymentTypeL LookupPaymentTypeL { get; set; }
        public int WorkAreaId { get; set; }
        public virtual LookupWorkAreaL LookupWorkAreaL { get; set; }
        public int DamageTypeId { get; set; }
        public virtual LookupDamageTypeL LookupDamageTypeL   { get; set; }
        public int LevyId { get; set; }
        public virtual LookupLevyInfoL LookupLevyInfoL { get; set; }
        public int FileDamageStatusId { get; set; }
        public virtual LookupFileDamageStatusL LookupFileDamageStatusL { get; set; }
        public int InsuranceExpid { get; set; }
        public virtual LookupInsuranceExplanationL LookupInsuranceExplanationL { get; set; }
        //_______________________________________________________________...


        public int Piece { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string PartInfo { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string FirmInfo { get; set; }

        [Column(TypeName = "Varchar(160)")]
        public string PayeeInfo { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Tarih Bilgisi Boş Bırakılamaz")]
        public DateTime SapPaymentDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Tarih Bilgisi Boş Bırakılamaz")]
        public DateTime SapPaymentYear { get; set; }
        public float PaymentAmount { get; set; }
        public float SapAmount { get; set; }
        public float CashCollateral { get; set; }

        [Column(TypeName = "Varchar(4000)")]
        public string InfoNote { get; set; }
        public bool Insurable { get; set; }
        public bool RecouseDeclaration { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string RecouseExplanation { get; set; }
        public float CalculatedRecouseAmount { get; set; }
        public float CollectionAmount { get; set; }
        public float RemainingAmount { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string CollectionChannel { get; set; }
        public bool CaseFinalSituation { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Tarih Bilgisi Boş Bırakılamaz")]
        public DateTime ErDatCreate { get; set; }

        [Column(TypeName = "Varchar(40)")]
        public string AdNameCreate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Tarih Bilgisi Boş Bırakılamaz")]
        public DateTime ErDatChange { get; set; }

        [Column(TypeName = "Varchar(40)")]
        public string AdNameChange { get; set; }

       
    }
}
