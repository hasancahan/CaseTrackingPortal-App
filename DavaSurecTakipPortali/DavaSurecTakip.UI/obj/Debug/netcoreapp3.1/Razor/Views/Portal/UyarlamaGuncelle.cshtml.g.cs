#pragma checksum "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\Portal\UyarlamaGuncelle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0304a9236443da968893f6e16a9366e00f4dc36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portal_UyarlamaGuncelle), @"mvc.1.0.view", @"/Views/Portal/UyarlamaGuncelle.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\_ViewImports.cshtml"
using DavaSurecTakip.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\_ViewImports.cshtml"
using DavaSurecTakip.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0304a9236443da968893f6e16a9366e00f4dc36", @"/Views/Portal/UyarlamaGuncelle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a60fdb2dcd6f710ff4336657bea6fb09f22c26a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portal_UyarlamaGuncelle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DavaSurecTakip.Entities.DbEntitiesModels.LookupAttornerL>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\Portal\UyarlamaGuncelle.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<h1>Uyarlama Güncelle</h1>
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css"" 
      rel=""stylesheet"" 
      integrity=""sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl"" 
      crossorigin=""anonymous"">

<div class=""form-box"">
");
#nullable restore
#line 14 "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\Portal\UyarlamaGuncelle.cshtml"
     using (Html.BeginForm("UyarlamaGuncelleData", "Portal", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\Portal\UyarlamaGuncelle.cshtml"
   Write(Html.Label("Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\Portal\UyarlamaGuncelle.cshtml"
   Write(Html.TextBoxFor(x => x.AttornerId, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 20 "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\Portal\UyarlamaGuncelle.cshtml"
   Write(Html.Label("Ad"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\Portal\UyarlamaGuncelle.cshtml"
   Write(Html.TextBoxFor(x => x.Attorner, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
            WriteLiteral("        <button class=\"btn btn-default\" style=\"background-color:#0c19b4 ; color:white\">Uyarlama Güncelle</button>\r\n        <button class=\"btn btn-default\" style=\"background-color:#FC1C00 ; color:white\">İptal</button>\r\n");
#nullable restore
#line 26 "E:\YEDEK 03.22\175541035_Hasan_Çahan_İşyeriEgitimiDosya\Kodlar\DicleElektrik.DavaSurecTakipPortali\DavaSurecTakip.UI\Views\Portal\UyarlamaGuncelle.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<style>
    body {
        background: #f7f7f7;
    }

    .form-box {
        max-width: 500px;
        margin: auto;
        padding: 50px;
        background: #ffffff;
        border: 10px solid #f2f2f2;
    }

    h1, p {
        text-align: center;
    }
</style>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DavaSurecTakip.Entities.DbEntitiesModels.LookupAttornerL> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
