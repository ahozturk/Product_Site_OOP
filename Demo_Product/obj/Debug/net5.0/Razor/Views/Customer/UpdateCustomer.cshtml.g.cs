#pragma checksum "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\Customer\UpdateCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "227a2cf4bf5488de97ad212b0b25b635bc7ed44b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_UpdateCustomer), @"mvc.1.0.view", @"/Views/Customer/UpdateCustomer.cshtml")]
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
#line 1 "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\_ViewImports.cshtml"
using Demo_Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\_ViewImports.cshtml"
using Demo_Product.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"227a2cf4bf5488de97ad212b0b25b635bc7ed44b", @"/Views/Customer/UpdateCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cfb9a0ef0ec1d3d285195ab224403920d5ac14", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_UpdateCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Customer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\Customer\UpdateCustomer.cshtml"
  
    ViewData["Title"] = "UpdateCustomer";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "227a2cf4bf5488de97ad212b0b25b635bc7ed44b3990", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\Customer\UpdateCustomer.cshtml"
Write(Html.Label("Name:"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\Customer\UpdateCustomer.cshtml"
Write(Html.TextBoxFor(x => x.Name, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 11 "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\Customer\UpdateCustomer.cshtml"
Write(Html.Label("City:"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 12 "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\Customer\UpdateCustomer.cshtml"
Write(Html.TextBoxFor(x => x.City, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 14 "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\Customer\UpdateCustomer.cshtml"
Write(Html.Label("Job:"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\Users\osaha\source\repos\Demo_Product\Product_Site_Core_5\Demo_Product\Views\Customer\UpdateCustomer.cshtml"
Write(Html.DropDownListFor(x => x.JobId, (List<SelectListItem>)ViewBag.v, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <button class=\"btn btn-success\">Update Customer</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
