#pragma checksum "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\CustomComponent\LeftMenuComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25bc14912f30d68d3b5356d0588cac73b93f465c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OgrenciServis.Component.CustomComponent
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
#nullable restore
#line 1 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\CustomComponent\LeftMenuComponent.razor"
using OgrenciServis.Component.BaseComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\CustomComponent\LeftMenuComponent.razor"
using OgrenciServis.Data;

#line default
#line hidden
#nullable disable
    public partial class LeftMenuComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Component\CustomComponent\LeftMenuComponent.razor"
       
    List<Menu> MenuList { get; set; }

    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected override Task OnInitializedAsync()
    {
        MenuDoldur();
        return base.OnInitializedAsync();
    }

    private void MenuDoldur()
    {
        MenuList = new List<Menu>();
        MenuList.Add(new Menu { DataIcon = "emojione:school", Title = "Okul" ,LinkName="okul"}); ;
        MenuList.Add(new Menu { DataIcon = "flat-color-icons:businesswoman", Title = "Veli" ,LinkName="veli"});
        MenuList.Add(new Menu { DataIcon = "flat-color-icons:graduation-cap", Title = "Öğrenci",LinkName="ogrenci" });
        MenuList.Add(new Menu { DataIcon = "flat-color-icons:assistant", Title = "Hostes",LinkName="hostes" });
        MenuList.Add(new Menu { DataIcon = "flat-color-icons:businessman", Title = "Şoför" ,LinkName="sofor"});
        MenuList.Add(new Menu { DataIcon = "emojione-bus", Title = "Araba" ,LinkName="araba"});
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591