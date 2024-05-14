using DavaSurecTakip.Entities.DbEntitiesModels;
using System.Collections.Generic;


namespace DavaSurecTakip.UI.Models
{
    public class TableListViewModel
    {
        
        public List<Case> cases { get; internal set; }
        public Case @case { get; set; }
        public PaidDamages damages { get; set; }
        public List<PaidDamages> paidDamages { get; internal set; }
        public List<LookupAttornerL> lookupAttornerL { get; internal set; }
        public LookupAttornerL attornerL { get; set; }
        public List<LookupCaseResultL> lookupCaseResultL { get; internal set; }
        public LookupCaseResultL caseResultL { get; set; }
        public LookupCaseSubjectL caseSubjectL{ get; set; }
        public List<LookupCaseSubjectL> lookupCaseSubjectL { get; set; }
        public List<LookupCourtInfoL> lookupCourtInfoL { get; set; }
        public LookupCourtInfoL courtInfoL { get; set; }
        public LookupDamageTypeL damageTypeL { get; set; }
        public List<LookupDamageTypeL> lookupDamageTypeL { get; set; }
        public LookupFileDamageStatusL damageStatusL { get; set; }
        public List<LookupFileDamageStatusL> lookupFileDamageStatuses { get; set; }
        public LookupFileStageL fileStageL  { get; set; }
        public List<LookupFileStageL> lookupFileStageL { get; set; }
        public List<LookupInsuranceExplanationL> lookupInsuranceExplanationL { get; set; }
        public LookupInsuranceExplanationL lookupInsurance { get; set; }
        public LookupLevyInfoL levyInfoL { get; set; }
        public List<LookupLevyInfoL> LookupLevyInfoL { get; set; }
        public LookupPaymentTypeL paymentTypeL { get; set; }
        public List<LookupPaymentTypeL> LookupPaymentTypeL { get; set; }
        public LookupProvinceL provinceL { get; set; }
        public List<LookupProvinceL> LookupProvinceL { get; set; }
        public LookupWorkAreaL workAreaL { get; set; }
        public List<LookupWorkAreaL> LookupWorkAreaL { get; set; }


    }
}
