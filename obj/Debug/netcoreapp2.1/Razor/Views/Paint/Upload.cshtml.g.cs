#pragma checksum "D:\Codes\Hakase\Views\Paint\Upload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fafb5d994e323760b9fb102cc76bb28431d6ee5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Paint_Upload), @"mvc.1.0.view", @"/Views/Paint/Upload.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Paint/Upload.cshtml", typeof(AspNetCore.Views_Paint_Upload))]
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
#line 1 "D:\Codes\Hakase\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\Codes\Hakase\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fafb5d994e323760b9fb102cc76bb28431d6ee5", @"/Views/Paint/Upload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Paint_Upload : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.ViewModels.UploadReformListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Paint", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUploadedImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
  
    ViewData["Title"] = "Upload";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
  
    bool isAdmin = Context.User.IsInRole("Admin");

#line default
#line hidden
            BeginContext(211, 31, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(242, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "235cb66fb970488780a46f880477626e", async() => {
                BeginContext(340, 188, true);
                WriteLiteral("\r\n        <label class=\"control-label\"> 壁または床の写真をアップロードします。</label>\r\n        <input type=\"file\" id=\"paintFileUpload\" name=\"source\" class=\"form-control\" placeholder=\"this is a test\"/>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(535, 14, true);
            WriteLiteral("\r\n    <br />\r\n");
            EndContext();
#line 17 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
     if (Context.User.Identity.IsAuthenticated)
    {

#line default
#line hidden
            BeginContext(605, 224, true);
            WriteLiteral("        <table class=\"table table-striped table-bordered\" style=\"width: 100%\" id=\"customerTable2\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        画像\r\n                    </th>\r\n");
            EndContext();
#line 25 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                     if (isAdmin)
                    {

#line default
#line hidden
            BeginContext(887, 97, true);
            WriteLiteral("                        <th>\r\n                            画像のURL\r\n                        </th>\r\n");
            EndContext();
#line 30 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                    }

#line default
#line hidden
            BeginContext(1007, 82, true);
            WriteLiteral("                    <th>\r\n                        作成日\r\n                    </th>\r\n");
            EndContext();
#line 34 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                     if (isAdmin)
                    {


#line default
#line hidden
            BeginContext(1149, 94, true);
            WriteLiteral("                        <th>\r\n                            作成者\r\n                        </th>\r\n");
            EndContext();
            BeginContext(1245, 188, true);
            WriteLiteral("                        <th>\r\n                            変更日\r\n                        </th>\r\n                        <th>\r\n                            編集者\r\n                        </th>\r\n");
            EndContext();
#line 47 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                    }

#line default
#line hidden
            BeginContext(1456, 99, true);
            WriteLiteral("                    <th></th>\r\n                </tr>\r\n            </thead>\r\n\r\n            <tbody>\r\n");
            EndContext();
#line 53 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                 foreach (var item in Model.UploadedImages)
                {

#line default
#line hidden
            BeginContext(1635, 88, true);
            WriteLiteral("                    <tr>\r\n                        <th>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1723, "\"", 1743, 1);
#line 57 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
WriteAttributeValue("", 1729, item.ImageUrl, 1729, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1744, 78, true);
            WriteLiteral(" style=\"max-height: 40px; max-width: 40px\" />\r\n                        </th>\r\n");
            EndContext();
#line 59 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                         if (isAdmin)
                        {


#line default
#line hidden
            BeginContext(1890, 66, true);
            WriteLiteral("                            <th>\r\n                                ");
            EndContext();
            BeginContext(1957, 13, false);
#line 63 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                           Write(item.ImageUrl);

#line default
#line hidden
            EndContext();
            BeginContext(1970, 37, true);
            WriteLiteral("\r\n                            </th>\r\n");
            EndContext();
#line 65 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                        }

#line default
#line hidden
            BeginContext(2034, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2093, 46, false);
#line 67 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
#line 69 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                         if (isAdmin)
                        {


#line default
#line hidden
            BeginContext(2240, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(2307, 46, false);
#line 73 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2353, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
            BeginContext(2392, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(2459, 47, false);
#line 77 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                           Write(Html.DisplayFor(modelItem => item.DateModified));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2610, 47, false);
#line 80 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserModified));

#line default
#line hidden
            EndContext();
            BeginContext(2657, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 82 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                        }

#line default
#line hidden
            BeginContext(2721, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2779, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cf123739da2455490f9f57b7f5b0805", async() => {
                BeginContext(2857, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-imgUrl", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                                                                              WriteLiteral(item.ImageUrl);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["imgUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-imgUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["imgUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2865, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2897, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "219d420b013d4021bb25620f686ac741", async() => {
                BeginContext(2957, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                                                                  WriteLiteral(item.Id);

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
            BeginContext(2967, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 88 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                }

#line default
#line hidden
            BeginContext(3046, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
            BeginContext(3088, 897, true);
            WriteLiteral(@"        <table class=""table table-striped table-bordered"" style=""width: 100%"" id=""customerTable"">
            <thead>
                <tr>
                    <th>
                        画像名
                    </th>
                    <th>
                        画像
                    </th>
                    <th>
                        元画像
                    </th>
                    <th>
                        画像のURL
                    </th>
                    <th>
                        作成日
                    </th>
                    <th>
                        作成者
                    </th>
                    <th>
                        変更日
                    </th>
                    <th>
                        編集者
                    </th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 123 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                 foreach (var item in Model.ReformedImages)
                {

#line default
#line hidden
            BeginContext(4065, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4150, 39, false);
#line 127 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4189, 95, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4284, "\"", 4318, 1);
#line 130 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
WriteAttributeValue("", 4290, item.UploadedImage.ImageUrl, 4290, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4319, 140, true);
            WriteLiteral(" style=\"max-height: 40px; max-width: 40px\" />\r\n                        </td>\r\n                        <td>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4459, "\"", 4479, 1);
#line 133 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
WriteAttributeValue("", 4465, item.ImageUrl, 4465, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4480, 136, true);
            WriteLiteral(" style=\"max-height: 40px; max-width: 40px\" />\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4617, 43, false);
#line 136 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                       Write(Html.DisplayFor(modelItem => item.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(4660, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4752, 46, false);
#line 139 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(4798, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(4890, 46, false);
#line 142 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserCreated));

#line default
#line hidden
            EndContext();
            BeginContext(4936, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5028, 47, false);
#line 145 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DateModified));

#line default
#line hidden
            EndContext();
            BeginContext(5075, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5167, 47, false);
#line 148 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserModified));

#line default
#line hidden
            EndContext();
            BeginContext(5214, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5305, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d95c48f8db5740a1b46ba249a9f6cb0a", async() => {
                BeginContext(5379, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 151 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                                                                          WriteLiteral(item.ImageUrl);

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
            BeginContext(5387, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(5419, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a8665d13484dabae4fbfedea1b53a2", async() => {
                BeginContext(5466, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 152 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                                                     WriteLiteral(item.Id);

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
            BeginContext(5476, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 155 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
                }

#line default
#line hidden
            BeginContext(5555, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 158 "D:\Codes\Hakase\Views\Paint\Upload.cshtml"
    }

#line default
#line hidden
            BeginContext(5602, 16, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.ViewModels.UploadReformListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
