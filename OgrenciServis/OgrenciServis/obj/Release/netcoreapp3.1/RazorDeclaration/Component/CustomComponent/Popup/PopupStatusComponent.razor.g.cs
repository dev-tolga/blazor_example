#pragma checksum "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\CustomComponent\Popup\PopupStatusComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1406c709a1904e4489e49d0c156d8eb66f735199"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OgrenciServis.Component.CustomComponent.Popup
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
    public partial class PopupStatusComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\CustomComponent\Popup\PopupStatusComponent.razor"
       
    [Parameter]
    public string Title { get; set; }
    /// <summary>
    /// alert alert-success
    /// alert alert-primary
    /// alert alert-secondary
    /// alert alert-danger
    /// alert alert-warning
    /// alert alert-info
    /// alert alert-light
    /// alert alert-dark
    /// </summary>
    [Parameter]
    public string StatusDurum { get; set; }
    [Parameter]
    public string ModalId { get; set; } = "";
    [Parameter]
    public int zIndex { get; set; } = 0;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591