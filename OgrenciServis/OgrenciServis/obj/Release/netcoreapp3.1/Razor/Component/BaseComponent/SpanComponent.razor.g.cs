#pragma checksum "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\BaseComponent\SpanComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa99d2d48717b1f7d4f703214204ab6d6835ed31"
// <auto-generated/>
#pragma warning disable 1591
namespace OgrenciServis.Component.BaseComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\_Imports.razor"
using OgrenciServis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\_Imports.razor"
using OgrenciServis.Shared;

#line default
#line hidden
#nullable disable
    public partial class SpanComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "span");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 1 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\BaseComponent\SpanComponent.razor"
              ClassName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddContent(3, 
#nullable restore
#line 2 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\BaseComponent\SpanComponent.razor"
     ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\BaseComponent\SpanComponent.razor"
       
    [Parameter]
    public string ClassName { get; set; }= "";

    [Parameter]
    public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
