#pragma checksum "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51602541f282110c70c6b94cb43f8315a816ab09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Notes), @"mvc.1.0.view", @"/Views/Note/Notes.cshtml")]
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
#line 1 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\_ViewImports.cshtml"
using WebAppClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\_ViewImports.cshtml"
using WebAppClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51602541f282110c70c6b94cb43f8315a816ab09", @"/Views/Note/Notes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cfb4d128d4ee781c69d28e2cdb7618fa50eabf4", @"/Views/_ViewImports.cshtml")]
    public class Views_Note_Notes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Note>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"d-flex flex-row justify-content-between mb-4\">\n    <span class=\"d-inline\"><h2>All Notes</h2></span>\n    ");
#nullable restore
#line 10 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml"
Write(Html.ActionLink("Add Note", "AddNote", "Note", "",new { @class="btn btn-primary", role="button"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<div class=""container"">
    <table class=""table table-hover"">
        <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Consumer</th>
            <th scope=""col"">Barber</th>
            <th scope=""col"">Haircut</th>
            <th scope=""col"">Data</th>
        </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml"
         foreach (var note in this.Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
#nullable restore
#line 28 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml"
                           Write(note.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 29 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml"
               Write(note.ConsumerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 30 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml"
               Write(note.BarberId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 31 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml"
               Write(note.HaircutId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml"
               Write(note.DateVisit.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 34 "C:\Users\andre\OneDrive\Рабочий стол\aaa\WebAppClient\WebAppClient\Views\Note\Notes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Note>> Html { get; private set; }
    }
}
#pragma warning restore 1591
