#pragma checksum "C:\190054\ToDoList\ToDoList\Views\ToDoList\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "751a08fc7e1ab8760d6bc65c8a6967e205289b8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoList_Create), @"mvc.1.0.view", @"/Views/ToDoList/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDoList/Create.cshtml", typeof(AspNetCore.Views_ToDoList_Create))]
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
#line 1 "C:\190054\ToDoList\ToDoList\Views\_ViewImports.cshtml"
using ToDoList;

#line default
#line hidden
#line 2 "C:\190054\ToDoList\ToDoList\Views\_ViewImports.cshtml"
using ToDoList.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"751a08fc7e1ab8760d6bc65c8a6967e205289b8a", @"/Views/ToDoList/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57829472ded1cf7bde1d515ed88d0e9bc5d97088", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoList_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 394, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>ToDo</h4>

<div>
    <label for=""seq"">Sequence</label>
    <input type=""text"" title=""seq"" id=""jobSeq"" />
</div>
<div>
    <label for=""title""> Job Title</label>
    <input type=""text"" title=""title"" id=""jobTitle"" />
</div>
<input type=""button"" id=""create"" value=""Create New Job"" />

<div>
    <a href=""https://localhost:44398/"">back to list</a>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(412, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "C:\190054\ToDoList\ToDoList\Views\ToDoList\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(482, 770, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(""#create"").click(function () {

            var json = JSON.stringify({ seq: $(""#jobSeq"").val(), title: $(""#jobTitle"").val() });
            $.ajax({
                url: 'https://localhost:44398/api/todolistapi/create-to-do',
                type: 'POST',
                contentType: 'application/json; charset=utf-8',
                data: json,
                dataType: 'json',
                success: function () {
                    location.href = ""https://localhost:44398/"";
                    console.log(json);
                },
                error: function (data, status, xhr) {
                    console.log(""error"");
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
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
