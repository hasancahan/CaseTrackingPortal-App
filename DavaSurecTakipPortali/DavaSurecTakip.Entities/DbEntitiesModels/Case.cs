using DavaSurecTakip.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DavaSurecTakip.Entities.DbEntitiesModels
{
    public class Case:IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CaseId { get; set; }
        public int CorporationId { get; set; }
        public int IHopeId { get; set; }
        //_______________________________________________________________İlişkiler Oluşturuldu...
        public virtual List<PaidDamages> PaidDamages { get; set; }
        public int CaseResultId { get; set; }
        public virtual LookupCaseResultL LookupCaseResultL { get; set; }
        public int CaseSubjectId { get; set; }
        public virtual LookupCaseSubjectL LookupCaseSubjectL { get; set; }
        public int FileStageId { get; set; }
        public virtual LookupFileStageL LookupFileStageL { get; set; }
        public int CourtInfoId { get; set; }
        public virtual LookupCourtInfoL LookupCourtInfoL { get; set; }
        public int ClaimantAttornerId { get; set; }
        public virtual LookupAttornerL LookupAttornerL { get; set; }
        public int DefendantAttornerId { get; set; }
        public virtual LookupAttornerL LookupAttorner { get; set; }
        public int ProvinceId { get; set; }
        public virtual LookupProvinceL LookupProvinceL { get; set; }
        //_______________________________________________________________...
        public string CaseResultDto { get; set; }
        public string CaseSubjectDto { get; set; }
        public string CaseFileStageDto { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Tarih Bilgisi Boş Bırakılamaz")]
        public DateTime TrialDay { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string ActualBasis { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public string OldBasis { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string Claimant { get; set; }

        [Column(TypeName = "Varchar(11)")]
        public string Tc { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string Defendant { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string SecondDefendant { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string Notified { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Tarih Bilgisi Boş Bırakılamaz")]
        public DateTime CaseDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Tarih Bilgisi Boş Bırakılamaz")]
        public DateTime EventDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Tarih Bilgisi Boş Bırakılamaz")]
        public DateTime EventYear { get; set; }
        public int CaseOpeningValue { get; set; }
        public int CaseActualValue { get; set; }
        public int InFavorOfAgencyFee { get; set; }
        public bool InterimInjunction { get; set; }
        public bool ObjectiveOfInterimInjunction { get; set; }
        public bool Archive { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}", NullDisplayText = "Tarih Bilgisi Boş Bırakılamaz")]
        public DateTime EffectiveDate { get; set; }

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