// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OgrenciServis.Component.BaseComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/_Imports.razor"
using OgrenciServis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/_Imports.razor"
using OgrenciServis.Shared;

#line default
#line hidden
#nullable disable
    public partial class TableComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor"
       
    [Parameter]
    public List<Object> ObjectList { get; set; }

    [Parameter]
    public Dictionary<string, string> KolonNames { get; set; }

    string[] kolonList { get; set; }

    protected override void OnInitialized()
    {
        //kolonList = KolonNames.Split(',');
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
