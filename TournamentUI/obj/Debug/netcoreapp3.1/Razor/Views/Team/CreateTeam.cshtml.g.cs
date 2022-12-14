#pragma checksum "/Users/macbook/Projects/Refactored/Tournament/TournamentUI/Views/Team/CreateTeam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b64311c4d1df358428503eaed9593d26313e286b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_CreateTeam), @"mvc.1.0.view", @"/Views/Team/CreateTeam.cshtml")]
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
#line 1 "/Users/macbook/Projects/Refactored/Tournament/TournamentUI/Views/_ViewImports.cshtml"
using TournamentUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/macbook/Projects/Refactored/Tournament/TournamentUI/Views/_ViewImports.cshtml"
using TournamentUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b64311c4d1df358428503eaed9593d26313e286b", @"/Views/Team/CreateTeam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2470689af97b1b78b8eb4b4a8b71e38f0ed896c", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_CreateTeam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/macbook/Projects/Refactored/Tournament/TournamentUI/Views/Team/CreateTeam.cshtml"
  
    ViewData["Title"] = "Create Team";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""center-contents"" id=""_info-add"">
    <h1 class=""_title"">Create Team</h1>
    <br />
    <div class=""d-flex justify-content-between box"">
        <div class=""left"" style=""border:none;"">
            <p>
                <div><strong>Team Name</strong></div>
                <input name=""teamName"" style=""width:100%"" />
            </p>
            <p>
                <div for=""teamMembers"" class=""d-flex justify-content-between"">
                    <strong>Select Team Member</strong>
                </div>
                <select name=""teamMembers"" style=""width:100%"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b64311c4d1df358428503eaed9593d26313e286b4166", async() => {
                WriteLiteral("~Select Team Member~");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </select>
                <p><button type=""button"" style=""margin:10px auto"">Add Team Member</button></p>
            </p>
            <p>
                <div><strong>Add New Member</strong></div>
                <div style=""border:1px solid #ccc; padding:10px;"" id=""_info-form"">
                    <p>
                        <label for=""FirstName"">First Name</label>
                        <input name=""FirstName"" />
                    </p>
                    <p>
                        <label for=""LastName"">Last Name</label>
                        <input name=""LastName"" />
                    </p>
                    <p>
                        <label for=""Email"">Email</label>
                        <input name=""Email"" />
                    </p>
                    <p>
                        <label for=""CellPhone"">Cell Phone</label>
                        <input name=""CellPhone"" />
                    </p>
                    <p><button type=""button"" style=""margin:10px auto"">Create Me");
            WriteLiteral(@"mber</button></p>
                </div>
            </p>
        </div>
        <div class=""right"">
            <ul class=""list-wrapper"">
                <li>List 1</li>
                <li>List 2</li>
                <li>List 3</li>
                <li>List 4</li>
            </ul>
        </div>
    </div>

    <p>
        <button type=""submit"">Create Team</button>
    </p>
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
