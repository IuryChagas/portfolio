#pragma checksum "C:\Users\DYGG\Desktop\Portfolio\Portfolio\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2f1c6c38eec502a24451ac9e500beb077f1ab5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\DYGG\Desktop\Portfolio\Portfolio\Views\_ViewImports.cshtml"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DYGG\Desktop\Portfolio\Portfolio\Views\_ViewImports.cshtml"
using Portfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2f1c6c38eec502a24451ac9e500beb077f1ab5e", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d587089adc4636fe5ec71d66b3e4e9e45c7e4694", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\DYGG\Desktop\Portfolio\Portfolio\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""site-section site-hero inner"">
    <div class=""container"">
        <div class=""row align-items-center"">
            <div class=""col-md-10"">
                <span class=""d-block mb-3 caption"" data-aos=""fade-up"">Get In Touch</span>
                <h1 class=""d-block mb-4"" data-aos=""fade-up"" data-aos-delay=""100"">Contact Me</h1>
            </div>
        </div>
    </div>
</div>

<div class=""site-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6"" data-aos=""fade-up"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2f1c6c38eec502a24451ac9e500beb077f1ab5e4333", async() => {
                WriteLiteral("\r\n\r\n\r\n                    <div class=\"row form-group\">\r\n                        <div class=\"col-md-6 mb-3 mb-md-0\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 773, "\"", 781, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"fname\">First Name</label>\r\n                            <input type=\"text\" id=\"fname\" class=\"form-control\">\r\n                        </div>\r\n                        <div class=\"col-md-6\">\r\n                            <label");
                BeginWriteAttribute("class", " class=\"", 1010, "\"", 1018, 0);
                EndWriteAttribute();
                WriteLiteral(@" for=""lname"">Last Name</label>
                            <input type=""text"" id=""lname"" class=""form-control"">
                        </div>
                    </div>

                    <div class=""row form-group"">

                        <div class=""col-md-12"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 1329, "\"", 1337, 0);
                EndWriteAttribute();
                WriteLiteral(@" for=""email"">Email</label>
                            <input type=""email"" id=""email"" class=""form-control"">
                        </div>
                    </div>

                    <div class=""row form-group"">

                        <div class=""col-md-12"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 1645, "\"", 1653, 0);
                EndWriteAttribute();
                WriteLiteral(@" for=""subject"">Subject</label>
                            <input type=""subject"" id=""subject"" class=""form-control"">
                        </div>
                    </div>

                    <div class=""row form-group"">
                        <div class=""col-md-12"">
                            <label");
                BeginWriteAttribute("class", " class=\"", 1967, "\"", 1975, 0);
                EndWriteAttribute();
                WriteLiteral(@" for=""message"">Message</label>
                            <textarea name=""message"" id=""message"" cols=""30"" rows=""7"" class=""form-control""></textarea>
                        </div>
                    </div>

                    <div class=""row form-group"">
                        <div class=""col-md-12"">
                            <input type=""submit"" value=""Send Message"" class=""btn btn-primary py-2 px-4 text-white"">
                        </div>
                    </div>


                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-md-5 ml-auto"" data-aos=""fade-up"" data-aos-delay=""100"">
                <div class=""p-4 mb-3"">
                    <p class=""mb-0 font-weight-bold text-secondary text-uppercase mb-3"">Address</p>
                    <p class=""mb-4"">Torre Trinity Corporate, Av. Sete de Setembro, 2451 - 6º andar - Rebouças, Curitiba - PR, 80250-210</p>

                    <p class=""mb-0 font-weight-bold text-secondary text-uppercase mb-3"">Phone</p>
                    <p class=""mb-4""><a href=""https://api.whatsapp.com/send?1=pt_BR&phone=5541992639508"" target=""_blank"">+55 (041) 99263-6508</a></p>

                    <p class=""mb-0 font-weight-bold text-secondary text-uppercase mb-3"">Email Address</p>
                    <p class=""mb-0""><a href=""mailto:iurychagas@icloud.com"" target=""_blank"">iurychagas@icloud.com</a></p>

                </div>
            </div>
        </div>
    </div>
</div>");
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
