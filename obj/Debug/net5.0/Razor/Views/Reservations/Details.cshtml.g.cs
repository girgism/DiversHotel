#pragma checksum "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c758edbf5689916c268bb01ffb603c8112da9880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Details), @"mvc.1.0.view", @"/Views/Reservations/Details.cshtml")]
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
#line 1 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\_ViewImports.cshtml"
using Divers_Hotel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\_ViewImports.cshtml"
using Divers_Hotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c758edbf5689916c268bb01ffb603c8112da9880", @"/Views/Reservations/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9935359186d736fca67af54432ee49efabe78f41", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Divers_Hotel.Models.Reservation>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
   if (ViewData["GName"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert  alert-success\">\r\n            <h4 class=\"alert-heading\">Reservation Process Done :) </h4>\r\n            <p class=\"mb-0\">Welcom MR : ");
#nullable restore
#line 12 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                                   Write(TempData["GName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            <p>the Total Price will be : <span font-weight:bold\">");
#nullable restore
#line 13 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                                                            Write(TempData["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</span> </p>\r\n        </div>\r\n");
#nullable restore
#line 15 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div>
    <h4 class=""text-info"">Reservation</h4>
    <hr />

    <div class=""container "">
        <div class=""row"">
            <div class=""card text-white text-center col-md-6"">
                <h4 class=""card-header bg-info"">Reservation details</h4>
                <div class=""card-body text-dark"">
                    <div class=""card-title bg-light p-2"">
                        <strong class=""col-md-4 text-left"">
                            ");
#nullable restore
#line 30 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.GuestName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8 text-left\">\r\n                            ");
#nullable restore
#line 33 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.GuestName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n\r\n                    <div class=\"card-title bg-light p-2\">\r\n                        <strong class=\"col-md-4 text-left\">\r\n                            ");
#nullable restore
#line 39 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.GuestEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8 text-left\">\r\n                            ");
#nullable restore
#line 42 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.GuestEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n\r\n                    <div class=\"card-title bg-light p-2\">\r\n                        <strong class=\"col-md-4 text-left\">\r\n                            ");
#nullable restore
#line 48 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.GuestCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8 text-left\">\r\n                            ");
#nullable restore
#line 51 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.GuestCountry));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n\r\n                    <div class=\"card-title bg-light p-0 \">\r\n                        <strong class=\"col-md-4 text-left\">\r\n                            ");
#nullable restore
#line 57 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.NumberOfAdults));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8 text-left\">\r\n                            ");
#nullable restore
#line 60 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.NumberOfAdults));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n\r\n                    <div class=\"card-title bg-light p-2\">\r\n                        <strong class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 66 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.NumberOfChilds));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 69 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.NumberOfChilds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n\r\n                    <div class=\"card-title bg-light p-2\">\r\n                        <strong class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 75 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.CheckIn));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 78 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.CheckIn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n\r\n                    <div class=\"card-title bg-light p-2\">\r\n                        <strong class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 84 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.CheckOut));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 87 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.CheckOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n\r\n                    <div class=\"card-title bg-light p-2\">\r\n                        <strong class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 93 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Meal));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 96 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Meal.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n\r\n                    <div class=\"card-title bg-light p-2\">\r\n                        <strong class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 102 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 105 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Room.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n                    \r\n                    <div class=\"card-title bg-light p-2\">\r\n                        <strong class=\"col-md-4\">\r\n                            ");
#nullable restore
#line 111 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n                        </strong>\r\n                        <strong class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 114 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                       Write(Html.DisplayFor(model => model.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </strong>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <div class=\"card-footer\">\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c758edbf5689916c268bb01ffb603c8112da988015171", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "E:\P R O J E C T S\__dotNet\Divers_Hotel\Views\Reservations\Details.cshtml"
                                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c758edbf5689916c268bb01ffb603c8112da988017433", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Divers_Hotel.Models.Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
