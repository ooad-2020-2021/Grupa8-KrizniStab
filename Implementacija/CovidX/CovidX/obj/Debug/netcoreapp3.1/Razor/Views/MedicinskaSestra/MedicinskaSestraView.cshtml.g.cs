#pragma checksum "C:\Users\Selma\Documents\GitHub\Grupa8-KrizniStab\Implementacija\CovidX\CovidX\Views\MedicinskaSestra\MedicinskaSestraView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27e472d26d84845882bad889c40976accbeedd30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MedicinskaSestra_MedicinskaSestraView), @"mvc.1.0.view", @"/Views/MedicinskaSestra/MedicinskaSestraView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27e472d26d84845882bad889c40976accbeedd30", @"/Views/MedicinskaSestra/MedicinskaSestraView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1d19aec8343059d4b47351e25f3fa610fc3e17", @"/Views/_ViewImports.cshtml")]
    public class Views_MedicinskaSestra_MedicinskaSestraView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top w-100 d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: -8px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27e472d26d84845882bad889c40976accbeedd304696", async() => {
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
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/aos/2.3.4/aos.css"">
    <link rel=""stylesheet"" href=""/Login-Form-Clean.css"">
    <link rel=""stylesheet"" href=""/Ludens-Users---2-Register.css"">
    <link rel=""stylesheet"" href=""/Ludens-Users---3-Profile.css"">
    <link rel=""stylesheet"" href=""/Map-Clean.css"">");
                WriteLiteral(@"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27e472d26d84845882bad889c40976accbeedd307551", async() => {
                WriteLiteral(@"
    <main class=""page"" style=""min-height: 100%;"">
        <section class=""clean-block about-us"" style=""border-style: none;"">
            <div class=""row"" style=""margin-right: 0px;margin-left: 0px;"">
                <div class=""col"">
                    <nav class=""navbar navbar-light navbar-expand-md"">
                        <div class=""container-fluid"">
                            <button data-toggle=""collapse"" class=""navbar-toggler"" data-target=""#navcol-1""><span class=""sr-only"">Toggle navigation</span><span class=""navbar-toggler-icon""></span></button>
                            <div class=""collapse navbar-collapse"" id=""navcol-1"">
                                <ul class=""navbar-nav"" style=""font-weight:bold"">
                                    <li class=""nav-item""><a class=""nav-link active"" href=""#"">Osoblje profil</a></li>
                                    <li class=""nav-item""><a class=""nav-link"" href=""#"">Kartoni pacijenata</a></li>
                                    <li class=""nav-item"">");
                WriteLiteral(@"<a class=""nav-link"" href=""#"">Rezervacija termina</a></li>
                                </ul>
                            </div>
                        </div>
                    </nav>
                </div>
            </div>
            <div class=""row"" style=""margin-right: 0px;margin-left: 0px;"">
                <div class=""col text-center"">
                    <h2 class=""text-info"" style=""margin-left: 122px;"">Medicines cure diseases, but only doctors can cure patients.</h2>
                </div>
            </div>
            <div class=""row justify-content-center"" style=""margin-right: 0px;margin-left: 59px;margin-top: 46px;"">
                <div class=""col-sm-6 col-lg-4"" style=""padding-right: 0px;padding-left: 0px;margin-top: 32px;margin-left: 144px;"">
                    <div class=""card clean-card text-center"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "27e472d26d84845882bad889c40976accbeedd309815", async() => {
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
                        <div class=""card-body info"">
                            <div class=""row"" style=""margin-top: -24px;"">
                                <div class=""col-md-12"" style=""margin-top: 22px;"">
                                    <div class=""row"">
                                        <div class=""col"">
                                            <p class=""labels"">Ime</p>
                                        </div>
                                        <div class=""col"">
                                            <p class=""labels""></p>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col"">
                                            <p class=""labels"">Prezime</p>
                                        </div>
                                        <div class=""col"">
                                            <p class=""labels""><");
                WriteLiteral(@"/p>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col"">
                                            <p class=""labels"">Datum rođenja</p>
                                        </div>
                                        <div class=""col"">
                                            <p class=""labels""></p>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col"">
                                            <p class=""labels"">JMBG</p>
                                        </div>
                                        <div class=""col"">
                                            <p class=""labels""></p>
                                        </div>
                                    </div>
            ");
                WriteLiteral(@"                        <div class=""row"">
                                        <div class=""col"">
                                            <p class=""labels"">Email</p>
                                        </div>
                                        <div class=""col"">
                                            <p class=""labels""></p>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col"">
                                            <p class=""labels"">Spol</p>
                                        </div>
                                        <div class=""col"">
                                            <p class=""labels""></p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
      ");
                WriteLiteral(@"                          <div class=""col"">
                                    <p class=""labels"">Kritična grupa</p>
                                </div>
                                <div class=""col"">
                                    <p class=""labels""></p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""labels"">Status</p>
                                </div>
                                <div class=""col"">
                                    <p class=""labels""></p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""labels"">Username</p>
                                </div>
                                <div class=""col"">
                              ");
                WriteLiteral(@"      <p class=""labels""></p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""labels"">Password</p>
                                </div>
                                <div class=""col"">
                                    <p class=""labels""></p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""labels"">Lokacija</p>
                                </div>
                                <div class=""col"">
                                    <p class=""labels""></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col"">
             ");
                WriteLiteral(@"       <header></header>
                </div>
            </div>
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
    <script id=""bs-live-reload"" data-sseport=""51103"" data-lastchange=""1622658806172"" src=""/js/livereload.js""></script>
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
