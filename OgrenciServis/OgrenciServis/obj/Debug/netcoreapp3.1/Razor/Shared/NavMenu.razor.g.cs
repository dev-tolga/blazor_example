#pragma checksum "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "901173eaa59087aa87244cc3bcb0b986f51bda15"
// <auto-generated/>
#pragma warning disable 1591
namespace OgrenciServis.Shared
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
#nullable restore
#line 1 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Shared/NavMenu.razor"
using OgrenciServis.Component.BaseComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Shared/NavMenu.razor"
using OgrenciServis.Component.CustomComponent;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(0);
            __builder.AddAttribute(1, "ClassName", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<OgrenciServis.Component.BaseComponent.ATagComponent>(4);
                __builder2.AddAttribute(5, "ClassName", "navbar-brand");
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "Öğrenci Takip Sistemi");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenComponent<OgrenciServis.Component.CustomComponent.LeftMenuComponent>(10);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
