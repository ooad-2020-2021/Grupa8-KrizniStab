#pragma checksum "C:\Users\Selma\Documents\GitHub\Grupa8-KrizniStab\Implementacija\CovidX\CovidX\Views\Pacijent\OnlinePlacanjeView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c58074b1dd1b19261482004c9ca2aa4d3d66d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacijent_OnlinePlacanjeView), @"mvc.1.0.view", @"/Views/Pacijent/OnlinePlacanjeView.cshtml")]
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
#line 1 "C:\Users\Selma\Documents\GitHub\Grupa8-KrizniStab\Implementacija\CovidX\CovidX\Views\_ViewImports.cshtml"
using CovidX;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Selma\Documents\GitHub\Grupa8-KrizniStab\Implementacija\CovidX\CovidX\Views\_ViewImports.cshtml"
using CovidX.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c58074b1dd1b19261482004c9ca2aa4d3d66d1", @"/Views/Pacijent/OnlinePlacanjeView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1d19aec8343059d4b47351e25f3fa610fc3e17", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacijent_OnlinePlacanjeView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid panel-title-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/accepted_cards.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 105px;margin-bottom: -14px;margin-top: -22px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 350px;height: 350px;margin-left: 74px;margin-top: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Selma\Documents\GitHub\Grupa8-KrizniStab\Implementacija\CovidX\CovidX\Views\Pacijent\OnlinePlacanjeView.cshtml"
  
    ViewData["Title"] = "Placanje";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c58074b1dd1b19261482004c9ca2aa4d3d66d15623", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, shrink-to-fit=no"">
    <title>home</title>
    <link rel=""stylesheet"" href=""/bootstrap/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=ABeeZee"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Abril+Fatface"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Alegreya"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Alegreya+SC"">
    <link rel=""stylesheet"" href=""/fonts/simple-line-icons.min.css"">
    <link rel=""stylesheet"" href=""/-Countdown-BS4-.css"">
    <link rel=""stylesheet"" href=""/Bootstrap-Payment-Form.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/aos/2.3.4/aos.css"">
    <link rel=""stylesheet"" href=""/Login-Form-Clean.css"">
    <link rel=""stylesheet"" href=""/Ludens-Users---2-Register.css"">
    <link rel=""stylesheet"" href=""/Ludens-Users---3-");
                WriteLiteral(@"Profile.css"">
    <link rel=""stylesheet"" href=""/Map-Clean.css"">
    <link rel=""stylesheet"" href=""/Navigation-with-Button.css"">
    <link rel=""stylesheet"" href=""/Off-Canvas-Sidebar-Drawer-Navbar.css"">
    <link rel=""stylesheet"" href=""/Pretty-Registration-Form.css"">
    <link rel=""stylesheet"" href=""/Profile-Edit-Form-1.css"">
    <link rel=""stylesheet"" href=""/Profile-Edit-Form.css"">
    <link rel=""stylesheet"" href=""/Projects-Clean.css"">
    <link rel=""stylesheet"" href=""/Registration-Form-with-Photo.css"">
    <link rel=""stylesheet"" href=""/sidebar-1.css"">
    <link rel=""stylesheet"" href=""/SIdebar-Responsive-2-1.css"">
    <link rel=""stylesheet"" href=""/SIdebar-Responsive-2.css"">
    <link rel=""stylesheet"" href=""/sidebar.css"">
    <link rel=""stylesheet"" href=""/styles.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c58074b1dd1b19261482004c9ca2aa4d3d66d18546", async() => {
                WriteLiteral("\r\n    <main class=\"page\" style=\"min-height: 100%;\">\r\n        <section class=\"clean-block about-us\">\r\n");
#nullable restore
#line 42 "C:\Users\Selma\Documents\GitHub\Grupa8-KrizniStab\Implementacija\CovidX\CovidX\Views\Pacijent\OnlinePlacanjeView.cshtml"
             using (Html.BeginForm("Plati", "Placanje", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c58074b1dd1b19261482004c9ca2aa4d3d66d19255", async() => {
                    WriteLiteral("\r\n                    <p style=\"color: rgb(0,0,0);text-align: center;margin-top: 43px;margin-left: 13px;\">Ostvarujete popust od 20% za online plaćanje.</p>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39c58074b1dd1b19261482004c9ca2aa4d3d66d19676", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                    <div class=""form-row"" style=""margin-top: 39px;"">
                        <div class=""col""><input class=""form-control"" name=""brojKartice"" type=""text"" placeholder=""Broj kartice""></div>
                    </div>
                    <p style=""margin-top: 24px;padding-left: 5px;"">Datum uplate:</p><input class=""form-control"" type=""date"" style=""margin-top: -13px;"">
                    <p style=""margin-top: 24px;margin-left: 6px;"">Datum isteka:</p><input class=""form-control"" type=""tel"" id=""cardExpiry-1"" name=""datumIsteka""");
                    BeginWriteAttribute("required", " required=\"", 3051, "\"", 3062, 0);
                    EndWriteAttribute();
                    WriteLiteral(" placeholder=\"MM / YY\" style=\"padding-top: 8px;margin-top: -17px;\">\r\n                \r\n\r\n                ");
#nullable restore
#line 53 "C:\Users\Selma\Documents\GitHub\Grupa8-KrizniStab\Implementacija\CovidX\CovidX\Views\Pacijent\OnlinePlacanjeView.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                <button class=\"btn btn-primary\" type=\"submit\" style=\"margin-left: 158px;margin-top: 19px;width: 78.1px;\">Plati</button>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\Selma\Documents\GitHub\Grupa8-KrizniStab\Implementacija\CovidX\CovidX\Views\Pacijent\OnlinePlacanjeView.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </section>
        </main>
            <script src=""/assets/js/jquery-3.6.0.min.js""></script>
            <script src=""/assets/bootstrap/js/bootstrap.min.js""></script>
            <script src=""/js/chart.min.js""></script>
            <script src=""/assets/js/bs-init.js""></script>
            <script src=""https://cdnjs.cloudflare.com/ajax/libs/aos/2.3.4/aos.js""></script>
            <script src=""/assets/js/Off-Canvas-Sidebar-Drawer-Navbar.js""></script>
            <script src=""/assets/js/Off-Canvas-Sidebar-Drawer-Navbar-1.js""></script>
            <script src=""/assets/js/-Countdown-BS4-.js""></script>
            <script src=""/assets/js/Profile-Edit-Form.js""></script>
            <script id=""bs-live-reload"" data-sseport=""64830"" data-lastchange=""1622803832805"" src=""/js/livereload.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
