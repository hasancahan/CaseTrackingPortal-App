using DavaSurecTakip.DataAccess.Concrete;
using DavaSurecTakip.Entities.DbEntitiesModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DavaSurecTakip.UI.Controllers
{
    public class LoginUIController : Controller
    {
        Context c = new Context();

        [HttpGet]
        public IActionResult LogIndex(string ReturnUrl)
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIndex(Users u , string ReturnUrl)
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            var bilgiler = c.Users.FirstOrDefault(x => x.UserName == u.UserName && x.UserPassword == u.UserPassword); 
            
            if (bilgiler == null)
            {
                TempData["Hata"] = "Kullanıcı Adı veya Şifreniz hatalıdır. Lütfen bilgilerinizi kontrol ediniz.";
                return RedirectToAction("LogIndex", "LoginUI");
                
            }
            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,u.UserName)
                };

                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("KullaniciIslem", "Portal");
            }
           
            return View("/LoginUI/LogIndex/");  
        }
    }
}

