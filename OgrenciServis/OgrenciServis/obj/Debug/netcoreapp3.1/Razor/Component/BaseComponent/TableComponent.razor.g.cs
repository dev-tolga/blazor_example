#pragma checksum "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d637366dbfdfb6cb92a7b0a4bcd5a118ab3a374"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table table-bordered table-striped");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "thead");
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 6 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor"
                     foreach (KeyValuePair<string, string> kolonAd in KolonNames)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                        ");
            __builder.OpenElement(14, "th");
            __builder.AddAttribute(15, "scope", "col");
            __builder.AddContent(16, 
#nullable restore
#line 8 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor"
                                         kolonAd.Value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 9 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "tbody");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 13 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor"
                 foreach (var itemObject in ObjectList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                    ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 16 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor"
                         foreach (KeyValuePair<string, string> itemKolon in KolonNames)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                            ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 18 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor"
                                 itemObject.GetType().GetProperty(itemKolon.Key).GetValue(itemObject)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 19 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 21 "/Users/tolgakeser/Projects/OgrenciServis/OgrenciServis/Component/BaseComponent/TableComponent.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
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