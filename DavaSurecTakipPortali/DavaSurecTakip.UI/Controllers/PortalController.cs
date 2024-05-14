using DavaSurecTakip.Business.Abstract;
using DavaSurecTakip.DataAccess.Concrete;
using DavaSurecTakip.Entities.DbEntitiesModels;
using DavaSurecTakip.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DavaSurecTakip.UI.Controllers
{
    public class PortalController : Controller
    {
        TableListViewModel tableListViewModel1 = new TableListViewModel();
        Context con = new Context();
        private IPaidDamagesService _paidDamagesService;
        private IUsersService _usersService;
        private ICaseService _caseService;
        private ILookupAttornerLService _lookupAttornerLService1;
        private ILookupCaseResultLService _lookupCaseResultLService;
        private ILookupCaseSubjectLService _lookupCaseSubjectLService;
        private ILookupCourtInfoLService _lookupCourtInfoLService;
        private ILookupDamageTypeLService _lookupDamageTypeLService;
        private ILookupFileDamageStatusLService _lookupFileDamageStatusLService;
        private ILookupFileStageLService _lookupFileStageLService;
        private ILookupInsuranceExplanationLService _lookupInsuranceExplanationLService;
        private ILookupLevyInfoLService _lookupLevyInfoLService;
        private ILookupPaymentTypeLService _lookupPaymentTypeLService;
        private ILookupProvinceLService _lookupProvinceLService;
        private ILookupWorkAreaLService _lookupWorkAreaLService;

        //Birden fazla oluşturucu eklemek istediğimizde metot yapısı bu şekilde olmalıdır. Değilse şu şekilde hata verir. 
        //invalidoperationexception: multiple constructors accepting all given argument types have been found in type 'davasurectakip.ui.controllers.portalcontroller'. there should only be one applicable constructor.
        public PortalController(IUsersService usersService, ICaseService caseService,ILookupAttornerLService lookupAttornerLService,ILookupCaseResultLService lookupCaseResultLService,
            ILookupCaseSubjectLService lookupCaseSubjectLService,ILookupCourtInfoLService lookupCourtInfoLService,ILookupDamageTypeLService lookupDamageTypeLService,
            ILookupFileDamageStatusLService lookupFileDamageStatusLService,ILookupFileStageLService lookupFileStageLService,ILookupInsuranceExplanationLService lookupInsuranceExplanationLService,
            ILookupLevyInfoLService lookupLevyInfoLService,ILookupPaymentTypeLService lookupPaymentTypeLService,ILookupProvinceLService lookupProvinceLService,
            ILookupWorkAreaLService lookupWorkAreaLService,IPaidDamagesService paidDamagesService)
        {
            _paidDamagesService = paidDamagesService;
            _usersService = usersService;
            _caseService = caseService;
            _lookupAttornerLService1 = lookupAttornerLService;
            _lookupCaseResultLService = lookupCaseResultLService;
            _lookupCaseSubjectLService = lookupCaseSubjectLService;
            _lookupCourtInfoLService = lookupCourtInfoLService;
            _lookupDamageTypeLService = lookupDamageTypeLService;
            _lookupFileDamageStatusLService = lookupFileDamageStatusLService;
            _lookupFileStageLService = lookupFileStageLService;
            _lookupInsuranceExplanationLService = lookupInsuranceExplanationLService;
            _lookupLevyInfoLService = lookupLevyInfoLService;
            _lookupPaymentTypeLService = lookupPaymentTypeLService;
            _lookupProvinceLService = lookupProvinceLService;
            _lookupWorkAreaLService = lookupWorkAreaLService;
        }

        //____________________________________________________________________________________________________________________
        //                                                     DAVA LİSTELERİ

        [HttpGet]
        public IActionResult DavaListe()
        {

            var PaidDamages = _paidDamagesService.GetAll();
            var Cases = _caseService.GetAll();
            TableListViewModel tableListViewModel = new TableListViewModel
            {
                cases = Cases,
                paidDamages=PaidDamages
            };

            List<SelectListItem> value1 = (from x in con.lookupCaseSubjectL.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.CaseSubject,
                                                 Value = x.CaseSubjectId.ToString()
                                             }).ToList();
            ViewBag.vlu1 = value1;
            List<SelectListItem> value2 = (from x in con.lookupProvinceL.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Province,
                                               Value = x.Province.ToString()
                                           }).ToList();
            ViewBag.vlu2 = value2;
            List<SelectListItem> value3 = (from x in con.lookupFileStageL.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.FileStage,
                                               Value = x.FileStageId.ToString()
                                           }).ToList();
            ViewBag.vlu3 = value3;
            List<SelectListItem> value4 = (from x in con.lookupCaseResultL.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CaseResult,
                                               Value = x.CaseResultId.ToString()
                                           }).ToList();
            ViewBag.vlu4 = value4;
            List<SelectListItem> value5 = (from x in con.lookupCourtInfoL.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CourtinInfo,
                                               Value = x.CourtinInfoId.ToString()
                                           }).ToList();
            ViewBag.vlu5 = value5;
            List<SelectListItem> value6 = (from x in con.cases.ToList()
                                           select new SelectListItem
                                           {
                                               Text = "True,False",
                                               Value = x.InterimInjunction.ToString()
                                           }).ToList();
            ViewBag.vlu6 = value6;
            List<SelectListItem> value7 = (from x in con.cases.ToList()
                                           select new SelectListItem
                                           {
                                               Text  = "True,False",
                                               Value = x.ObjectiveOfInterimInjunction.ToString()
                                           }).ToList();
            ViewBag.vlu7 = value7;
            List<SelectListItem> value8 = (from x in con.cases.ToList()
                                           select new SelectListItem
                                           {
                                               Text  = "True,False",
                                               Value = x.Archive.ToString()
                                           }).ToList();
            ViewBag.vlu8 = value8;
            List<SelectListItem> value9 = (from x in con.paidDamages.ToList()
                                           select new SelectListItem
                                           {
                                               Value = x.RowNumb.ToString()
                                           }).ToList();
            ViewBag.vlu9 = value9;
            List<SelectListItem> value10 = (from x in con.lookupPaymentTypeL.ToList()
                                           select new SelectListItem
                                           {
                                               Text  = x.PaymentType,
                                               Value = x.PaymentTypeId.ToString()
                                           }).ToList();
            ViewBag.vlu10 = value10;
            List<SelectListItem> value11 = (from x in con.lookupWorkAreaL.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.WorkArea,
                                                Value = x.WorkAreaId.ToString()
                                            }).ToList();
            ViewBag.vlu11 = value11;
            List<SelectListItem> value12 = (from x in con.lookupLevyInfoL.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.LevyInfo,
                                                Value = x.LevyInfoId.ToString()
                                            }).ToList();
            ViewBag.vlu12 = value12;
            List<SelectListItem> value13 = (from x in con.lookupDamageTypeL.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.DamageType,
                                                Value = x.DamageTypeId.ToString()
                                            }).ToList();
            ViewBag.vlu13 = value13;
            List<SelectListItem> value14 = (from x in con.lookupFileDamageStatusL.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.FileDamagesStatus,
                                                Value = x.DamageStatusId.ToString()
                                            }).ToList();
            ViewBag.vlu14 = value14;
            List<SelectListItem> value15 = (from x in con.lookupInsuranceExplanationL.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.InsuranceExplanation,
                                                Value = x.InsuranceExplanationId.ToString()
                                            }).ToList();
            ViewBag.vlu15 = value15;
            List<SelectListItem> value16 = (from x in con.paidDamages.ToList()
                                            select new SelectListItem
                                            {     
                                                Value = x.CaseFinalSituation.ToString()
                                            }).ToList();
            ViewBag.vlu16 = value16;

            return View(tableListViewModel);
        }

        [HttpPost]
        public IActionResult DavaListe(Case @case,PaidDamages paidDamages, string menu1btn, string menu2btn)
        {
            if (menu1btn != null)
            {
                _caseService.Add(@case);
            }
            else if (menu2btn != null)
            {
                _paidDamagesService.Add(paidDamages);
            }
            return RedirectToAction("DavaListe");
        }
        public IActionResult DavaSilme(int Id)
        {
            _caseService.Delete(Id);
            return RedirectToAction("DavaListe");
        }
        public IActionResult DavaGuncelle(int Id)
        {
            var idvalue = _caseService.GetById(Id);
            return View("DavaGuncelle", idvalue);
        }
        [HttpPost]
        public IActionResult DavaGuncelleData(Case @case)
        {
            _caseService.Update(@case);
            return RedirectToAction("DavaListe");
        }
        //____________________________________________________________________________________________________________________
        //                                                   KULLANICI İSLEMLERİ

        [HttpGet]
        public IActionResult KullaniciIslem()
        {
            var users = _usersService.GetAll();
            UsersListViewModel listViewModel = new UsersListViewModel
            {
                Users = users
            };
            return View(listViewModel);

        }

        [HttpPost]
        public IActionResult KullaniciIslem(Users users)
        {

            _usersService.Add(users);
            return RedirectToAction("KullaniciIslem");

        }
        public IActionResult KullaniciGuncelle(int Id)
        {            
            var idvalue = con.Users.Find(Id);
            //var idvalue = _usersService.GetById(Id);
            return View("KullaniciGuncelle",idvalue);

        } 

        [HttpPost]
        public IActionResult KullaniciGuncelleData(Users users)
        {

            _usersService.Update(users);
            return RedirectToAction("KullaniciIslem");

        }
        public IActionResult KullaniciSilme(int Id)
        {
            _usersService.Delete(Id);
            return RedirectToAction("KullaniciIslem");
        }

        //____________________________________________________________________________________________________________________
        //                                                   UYARLAMA TABLOLARI

        [HttpGet]
        public IActionResult Uyarlamalar()
        {
            var listlookupCaseResultL = _lookupCaseResultLService.GetAll();
            var listlookupAttornerL = _lookupAttornerLService1.GetAll();
            var listlookupCaseSubjectL = _lookupCaseSubjectLService.GetAll();
            var listlookupCourtInfoL = _lookupCourtInfoLService.GetAll();
            var listlookupDamageTypeL = _lookupDamageTypeLService.GetAll();
            var listlookupFileDamageStatusL = _lookupFileDamageStatusLService.GetAll();
            var listlookupFileStageL= _lookupFileStageLService.GetAll();
            var listlookupInsuranceExplanationL= _lookupInsuranceExplanationLService.GetAll();
            var listlookupLevyInfoL= _lookupLevyInfoLService.GetAll();
            var listlookupPaymentTypeL= _lookupPaymentTypeLService.GetAll();
            var listlookupProvinceL= _lookupProvinceLService.GetAll();
            var listlookupWorkAreaL= _lookupWorkAreaLService.GetAll();

            TableListViewModel listViewModel = new TableListViewModel
            {
                lookupAttornerL =  listlookupAttornerL,
                lookupCaseResultL= listlookupCaseResultL,
                lookupCaseSubjectL=listlookupCaseSubjectL,
                lookupCourtInfoL=  listlookupCourtInfoL,
                lookupDamageTypeL= listlookupDamageTypeL,
                lookupFileDamageStatuses=listlookupFileDamageStatusL,
                lookupFileStageL=listlookupFileStageL,
                lookupInsuranceExplanationL=listlookupInsuranceExplanationL,
                LookupLevyInfoL=listlookupLevyInfoL,
                LookupPaymentTypeL=listlookupPaymentTypeL,
                LookupProvinceL=listlookupProvinceL,
                LookupWorkAreaL=listlookupWorkAreaL

            };
            return View(listViewModel);   
        }

        [HttpPost]
        public IActionResult Uyarlamalar(TableListViewModel tableListViewModel,string btn1, string btn2, string btn3, string btn4, string btn5, string btn6, string btn7, string btn8, 
            string btn9, string btn10, string btn11, string btn12)
        {
         
            if (btn1 != null)
            {
                _lookupAttornerLService1.Add(tableListViewModel.attornerL);
            }
             else if (btn2 != null)
            {
                _lookupCaseResultLService.Add(tableListViewModel.caseResultL);
            }
            else if (btn3 != null)
            {
                _lookupWorkAreaLService.Add(tableListViewModel.workAreaL);
            }
            else if (btn4 != null)
            {
                _lookupCaseSubjectLService.Add(tableListViewModel.caseSubjectL);
            }
            else if (btn5 != null)
            {
                _lookupCourtInfoLService.Add(tableListViewModel.courtInfoL);
            }
            else if (btn6 != null)
            {
                _lookupDamageTypeLService.Add(tableListViewModel.damageTypeL);
            }
            else if (btn7 != null)
            {
                _lookupFileDamageStatusLService.Add(tableListViewModel.damageStatusL);
            }
            else if (btn8 != null)
            {
                _lookupFileStageLService.Add(tableListViewModel.fileStageL);
            }
            else if (btn9 != null)
            {
                _lookupInsuranceExplanationLService.Add(tableListViewModel.lookupInsurance);
            }
            else if (btn10 != null)
            {
                _lookupLevyInfoLService.Add(tableListViewModel.levyInfoL);
            }
            else if (btn11 != null)
            {
                _lookupPaymentTypeLService.Add(tableListViewModel.paymentTypeL);
            }
            else if (btn12 != null)
            {
                _lookupProvinceLService.Add(tableListViewModel.provinceL);
            }
            return RedirectToAction("Uyarlamalar");
        }

        public IActionResult UyarlamaGuncelle(int Id)
        {
            var idvalue = _lookupAttornerLService1.GetById(Id);
            return View("Uyarlamalar", idvalue);
        }

        [HttpPost]
        public IActionResult UyarlamaGuncelleData(LookupAttornerL lookupAttornerL)
        {
            _lookupAttornerLService1.Update(lookupAttornerL);
            return RedirectToAction("Uyarlamalar");
        }

        public IActionResult UyarlamaSil(int Id)
        {
            _lookupAttornerLService1.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil2(int Id)
        {
            _lookupCaseResultLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil3(int Id)
        {
            _lookupWorkAreaLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil4(int Id)
        {
            _lookupCaseSubjectLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil5(int Id)
        {
            _lookupCourtInfoLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil6(int Id)
        {
            _lookupDamageTypeLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil7(int Id)
        {
            _lookupFileDamageStatusLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil8(int Id)
        {
            _lookupFileStageLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil9(int Id)
        {
            _lookupInsuranceExplanationLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil10(int Id)
        {
            _lookupLevyInfoLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil11(int Id)
        {
            _lookupPaymentTypeLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }
        public IActionResult UyarlamaSil12(int Id)
        {
            _lookupProvinceLService.Delete(Id);
            return RedirectToAction("Uyarlamalar");
        }

    }
}