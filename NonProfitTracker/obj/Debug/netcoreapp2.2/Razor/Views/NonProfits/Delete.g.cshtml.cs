#pragma checksum "/Users/Guest/Desktop/RelationsPractice.Solution/NonProfitTracker/Views/NonProfits/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a75fcdd794e1dfcd8821526edefd0c29763e5d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NonProfits_Delete), @"mvc.1.0.view", @"/Views/NonProfits/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NonProfits/Delete.cshtml", typeof(AspNetCore.Views_NonProfits_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a75fcdd794e1dfcd8821526edefd0c29763e5d9", @"/Views/NonProfits/Delete.cshtml")]
    public class Views_NonProfits_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NonProfitTracker.Models.NonProfit>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/RelationsPractice.Solution/NonProfitTracker/Views/NonProfits/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(69, 69, true);
            WriteLiteral("\n<h2>Delete?</h2>\n<h4>Are you sure you want to delete this?</h4>\n\n<p>");
            EndContext();
            BeginContext(139, 40, false);
#line 10 "/Users/Guest/Desktop/RelationsPractice.Solution/NonProfitTracker/Views/NonProfits/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(179, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(182, 36, false);
#line 10 "/Users/Guest/Desktop/RelationsPractice.Solution/NonProfitTracker/Views/NonProfits/Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(218, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/RelationsPractice.Solution/NonProfitTracker/Views/NonProfits/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(251, 58, true);
            WriteLiteral("    <input class=\"button\" type=\"submit\" value=\"Delete\" />\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/RelationsPractice.Solution/NonProfitTracker/Views/NonProfits/Delete.cshtml"
}

#line default
#line hidden
            BeginContext(312, 40, false);
#line 15 "/Users/Guest/Desktop/RelationsPractice.Solution/NonProfitTracker/Views/NonProfits/Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NonProfitTracker.Models.NonProfit> Html { get; private set; }
    }
}
#pragma warning restore 1591