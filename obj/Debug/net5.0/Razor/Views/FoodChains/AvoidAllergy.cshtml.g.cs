#pragma checksum "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5d61605f130b4153f06ab610780767ad0e59ec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FoodChains_AvoidAllergy), @"mvc.1.0.view", @"/Views/FoodChains/AvoidAllergy.cshtml")]
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
#line 1 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\_ViewImports.cshtml"
using Restaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\_ViewImports.cshtml"
using Restaurant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5d61605f130b4153f06ab610780767ad0e59ec1", @"/Views/FoodChains/AvoidAllergy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d13f248a53660502ff72c6313477a5ca0c25306", @"/Views/_ViewImports.cshtml")]
    public class Views_FoodChains_AvoidAllergy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant.ViewModels.AllergyGroupFoodChain>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AvoidAllergy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1>Restaurants</h1>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d61605f130b4153f06ab610780767ad0e59ec16112", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            <p>\r\n                Search By Restaurant Name: <input id=\"searchString\" type=\"text\" name=\"SearchString\"");
                BeginWriteAttribute("value", " value=\"", 284, "\"", 318, 1);
#nullable restore
#line 10 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
WriteAttributeValue("", 292, ViewData["CurrentFilter"], 292, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> |\r\n                Select Allergy Group:\r\n                ");
#nullable restore
#line 12 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
           Write(Html.DropDownList("allergyselect", new SelectList(Model.AllergyGroups, "GroupID", "GroupName"), new { @id = "groupSelect" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input type=\"hidden\" id=\"hiddenGroupSelect\" name=\"selectedValue\"");
                BeginWriteAttribute("value", " value=\"", 588, "\"", 622, 1);
#nullable restore
#line 13 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
WriteAttributeValue("", 596, ViewData["selectedValue"], 596, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"submit\" value=\"Search\" class=\"search-btn\" /> |\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d61605f130b4153f06ab610780767ad0e59ec18079", async() => {
                    WriteLiteral("Clear all filters");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 20 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
     foreach (var item in Model.FoodChains)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row border-top p-3\">\r\n            <div class=\"col-md-4 text-center\">\r\n                <h4>");
#nullable restore
#line 24 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
               Write(Html.DisplayFor(modelItem => item.FoodChainName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d61605f130b4153f06ab610780767ad0e59ec111379", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                                                                       WriteLiteral(item.FoodChainID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <h5>Description</h5><p>");
#nullable restore
#line 28 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <h5>Restaurant Menu</h5>\r\n");
#nullable restore
#line 30 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                 if (item.MenuLink != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"justify-content-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d61605f130b4153f06ab610780767ad0e59ec114599", async() => {
                WriteLiteral("\r\n                            <input type=\"submit\" class=\"btn btn-dark\" value=\"Download\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                                                                    WriteLiteral(item.FoodChainID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 37 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"justify-content-center\">\r\n                        <p>No Menu Available</p>\r\n                    </div>\r\n");
#nullable restore
#line 43 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-4\">\r\n                <p><strong>Gluten Free Options?</strong> ");
#nullable restore
#line 46 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.GlutenFreeOptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Dairy Free Options?</strong> ");
#nullable restore
#line 47 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.DairyFreeOptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Nut Free Options?</strong> ");
#nullable restore
#line 48 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.NutFreeOptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Vegetarian Options?</strong> ");
#nullable restore
#line 49 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.VegetarianOptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Vegan Options?</strong> ");
#nullable restore
#line 50 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.VeganOptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Other Accommodations:</strong> ");
#nullable restore
#line 51 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.OtherOptions));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 54 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<p class=\"d-none\">");
#nullable restore
#line 58 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
             Write(ViewData["AllergyNames"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 60 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
  
    var prevDisabled = !Model.FoodChains.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !Model.FoodChains.HasNextPage ? "disabled" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d61605f130b4153f06ab610780767ad0e59ec121819", async() => {
                WriteLiteral("\r\n    Previous\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
              WriteLiteral(Model.FoodChains.PageIndex - 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 67 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                WriteLiteral(ViewData["allergyselect"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["allergyselect"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-allergyselect", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["allergyselect"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                WriteLiteral(ViewData["selectedValue"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selectedValue"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-selectedValue", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selectedValue"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3224, "btn", 3224, 3, true);
            AddHtmlAttributeValue(" ", 3227, "btn-default", 3228, 12, true);
#nullable restore
#line 70 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
AddHtmlAttributeValue(" ", 3239, prevDisabled, 3240, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d61605f130b4153f06ab610780767ad0e59ec127077", async() => {
                WriteLiteral("\r\n    Next\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
              WriteLiteral(Model.FoodChains.PageIndex + 1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                WriteLiteral(ViewData["allergyselect"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["allergyselect"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-allergyselect", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["allergyselect"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
                WriteLiteral(ViewData["selectedValue"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selectedValue"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-selectedValue", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["selectedValue"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3549, "btn", 3549, 3, true);
            AddHtmlAttributeValue(" ", 3552, "btn-default", 3553, 12, true);
#nullable restore
#line 78 "C:\Users\GDswo\Desktop\Folders\Productivity and Work\University\workspace\609it\Final Year Project\Views\FoodChains\AvoidAllergy.cshtml"
AddHtmlAttributeValue(" ", 3564, nextDisabled, 3565, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant.ViewModels.AllergyGroupFoodChain> Html { get; private set; }
    }
}
#pragma warning restore 1591
