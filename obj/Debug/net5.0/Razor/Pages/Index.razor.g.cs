#pragma checksum "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f90f0d8691ba0ac927698f6cfce8caf490d8d5e3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\_Imports.razor"
using Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Coronavirus Data</h1>\r\n");
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\Pages\Index.razor"
     DateHelper.formatedDate()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<BlazorApp.Pages.StateList>(4);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Jabbe\OneDrive\Documents\School Work\CIS 386\BlazorApp\Pages\Index.razor"
           
    StateList s = new StateList();

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
