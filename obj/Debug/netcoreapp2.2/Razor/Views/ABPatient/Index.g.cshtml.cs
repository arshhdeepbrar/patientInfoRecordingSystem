#pragma checksum "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010da46ef5a576dcc1461bf3fabf02b6d182c22d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ABPatient_Index), @"mvc.1.0.view", @"/Views/ABPatient/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ABPatient/Index.cshtml", typeof(AspNetCore.Views_ABPatient_Index))]
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
#line 1 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\_ViewImports.cshtml"
using ABPatients;

#line default
#line hidden
#line 2 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\_ViewImports.cshtml"
using ABPatients.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"010da46ef5a576dcc1461bf3fabf02b6d182c22d", @"/Views/ABPatient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7097be616f1c5cf1212c4a76ef3dcf132cd85eb5", @"/Views/_ViewImports.cshtml")]
    public class Views_ABPatient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ABPatients.Models.Patient>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ABPatientDiagnosis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
  
    ViewData["Title"] = "Patients on File";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(126, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(133, 17, false);
#line 8 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(150, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 9 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
     if (User.IsInRole("administrators") || User.IsInRole("medicalStaff"))
    {

#line default
#line hidden
            BeginContext(240, 25, true);
            WriteLiteral("        <p>\r\n            ");
            EndContext();
            BeginContext(265, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010da46ef5a576dcc1461bf3fabf02b6d182c22d5748", async() => {
                BeginContext(288, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(302, 16, true);
            WriteLiteral("\r\n        </p>\r\n");
            EndContext();
#line 14 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(325, 183, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    Patient Name\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(509, 43, false);
#line 22 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(552, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(620, 47, false);
#line 25 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(667, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(735, 47, false);
#line 28 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DateOfDeath));

#line default
#line hidden
            EndContext();
            BeginContext(782, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(850, 45, false);
#line 31 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(895, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1058, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1118, 246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010da46ef5a576dcc1461bf3fabf02b6d182c22d9750", async() => {
                BeginContext(1270, 43, false);
#line 41 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                                                                                                                                                                      Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(1313, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(1316, 44, false);
#line 41 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                                                                                                                                                                                                                    Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-patientId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                                                                    WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["patientId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-patientId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["patientId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                                                                                                          WriteLiteral(item.FirstName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["firstName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-firstName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["firstName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 41 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                                                                                                                                               WriteLiteral(item.LastName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lastName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-lastName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["lastName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1364, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1432, 42, false);
#line 44 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1474, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 47 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                      
                        string dateOfBirth = "";
                        if (item.DateOfBirth.HasValue)
                        {
                            dateOfBirth = item.DateOfBirth.Value.ToString("dd MMM yyyy");
                        }
                    

#line default
#line hidden
            BeginContext(1819, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1840, 41, false);
#line 54 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => dateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1881, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 57 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                      
                        string dateOfDeath = "";
                        if (item.DateOfDeath.HasValue)
                        {
                            dateOfDeath = item.DateOfDeath.Value.ToString("dd MMM yyyy");
                        }
                    

#line default
#line hidden
            BeginContext(2226, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(2247, 41, false);
#line 64 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => dateOfDeath));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2356, 44, false);
#line 67 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 69 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                 if (User.IsInRole("administrators") || User.IsInRole("medicalStaff"))
                {

#line default
#line hidden
            BeginContext(2532, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2582, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010da46ef5a576dcc1461bf3fabf02b6d182c22d17847", async() => {
                BeginContext(2634, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                                               WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2642, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2670, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010da46ef5a576dcc1461bf3fabf02b6d182c22d20223", async() => {
                BeginContext(2724, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 73 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                                                 WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2734, 30, true);
            WriteLiteral("|\r\n                    </td>\r\n");
            EndContext();
#line 75 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2783, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(2825, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "010da46ef5a576dcc1461bf3fabf02b6d182c22d22901", async() => {
                BeginContext(2880, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
                                              WriteLiteral(item.PatientId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2891, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 80 "C:\Users\arshd\Downloads\ABPatients\ABPatients\ABPatients\Views\ABPatient\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2950, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ABPatients.Models.Patient>> Html { get; private set; }
    }
}
#pragma warning restore 1591
