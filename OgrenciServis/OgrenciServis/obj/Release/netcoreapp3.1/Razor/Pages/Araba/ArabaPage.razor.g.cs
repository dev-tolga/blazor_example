#pragma checksum "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dbb88c8ece7f84198f4b7dd1aa4003dc1868413"
// <auto-generated/>
#pragma warning disable 1591
namespace OgrenciServis.Pages.Araba
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
#line 4 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
using OgrenciServis.Component.BaseComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
using OgrenciServis.Component.CustomComponent.Card;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/araba")]
    public partial class ArabaPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<OgrenciServis.Component.CustomComponent.Card.CardComponent>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<OgrenciServis.Component.CustomComponent.Card.CardHeaderComponent>(3);
                __builder2.AddAttribute(4, "Title", "??of??r Detay");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<OgrenciServis.Component.CustomComponent.Card.CardBodyComponent>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(9);
                    __builder3.AddAttribute(10, "ClassName", "form-group row");
                    __builder3.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(12, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(13);
                        __builder4.AddAttribute(14, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(16, "\r\n                ");
                            __builder5.OpenElement(17, "input");
                            __builder5.AddAttribute(18, "type", "text");
                            __builder5.AddAttribute(19, "class", "form-control btn-block");
                            __builder5.AddAttribute(20, "placeholder", "Plaka Giriniz.");
                            __builder5.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
                                     ArabaObject.ArabaPlaka

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(22, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ArabaObject.ArabaPlaka = __value, ArabaObject.ArabaPlaka));
                            __builder5.SetUpdatesAttributeName("value");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(23, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(24, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(26);
                    __builder3.AddAttribute(27, "ClassName", "form-group row");
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(29, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(30);
                        __builder4.AddAttribute(31, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(33, "\r\n                ");
                            __builder5.OpenElement(34, "input");
                            __builder5.AddAttribute(35, "type", "text");
                            __builder5.AddAttribute(36, "class", "form-control btn-block");
                            __builder5.AddAttribute(37, "placeholder", "Hostes soyad??n?? giriniz.");
                            __builder5.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
                                     ArabaObject.KoldukSayisi

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(39, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ArabaObject.KoldukSayisi = __value, ArabaObject.KoldukSayisi));
                            __builder5.SetUpdatesAttributeName("value");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(40, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(41, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(43);
                    __builder3.AddAttribute(44, "ClassName", "form-group row");
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(46, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(47);
                        __builder4.AddAttribute(48, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(50, "\r\n                ");
                            __builder5.OpenElement(51, "input");
                            __builder5.AddAttribute(52, "type", "text");
                            __builder5.AddAttribute(53, "class", "form-control btn-block");
                            __builder5.AddAttribute(54, "placeholder", "Araba markas?? giriniz.");
                            __builder5.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
                                     ArabaObject.Marka

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(56, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ArabaObject.Marka = __value, ArabaObject.Marka));
                            __builder5.SetUpdatesAttributeName("value");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(57, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(58, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(59, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(60);
                    __builder3.AddAttribute(61, "ClassName", "form-group row");
                    __builder3.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(63, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(64);
                        __builder4.AddAttribute(65, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(67, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.ButtonComponent>(68);
                            __builder5.AddAttribute(69, "ClassName", "btn btn-success float-right");
                            __builder5.AddAttribute(70, "ButtonName", "Kaydet");
                            __builder5.AddAttribute(71, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
                                          ArabaKaydet

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(72, "IsPopupBtn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
                                             false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(73, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(74, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(75, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(76);
                    __builder3.AddAttribute(77, "ClassName", "form-group row");
                    __builder3.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(79, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(80);
                        __builder4.AddAttribute(81, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(83, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.TableComponent>(84);
                            __builder5.AddAttribute(85, "KolonNames", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 49 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
                                            kolonVeliIsimleri

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(86, "ObjectList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.Object>>(
#nullable restore
#line 50 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
                                            ArabaList.Cast<object>().ToList()

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(87, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(88, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(89, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n    ");
                __builder2.OpenComponent<OgrenciServis.Component.CustomComponent.Card.CardFooterComponent>(91);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Araba\ArabaPage.razor"
       
    public OgrenciServis.Data.Araba ArabaObject;
    public List<OgrenciServis.Data.Araba> ArabaList;
    public Dictionary<string, string> kolonVeliIsimleri;

    protected override void OnInitialized()
    {
        ArabaObject = new Data.Araba();
        ArabaList = new List<Data.Araba>();
        kolonIsmiDoldur();
    }

    public void kolonIsmiDoldur()
    {
        kolonVeliIsimleri = new Dictionary<string, string>();
        kolonVeliIsimleri.Add("Id", "Id");
        kolonVeliIsimleri.Add("Marka", "Marka");
        kolonVeliIsimleri.Add("ArabaPlaka", "Plaka");
        kolonVeliIsimleri.Add("KoldukSayisi", "Koltuk Say??s??");
    }

    public void ArabaKaydet()
    {
        ArabaList.Add(new Data.Araba { Id=0,ArabaPlaka=ArabaObject.ArabaPlaka,KoldukSayisi=ArabaObject.KoldukSayisi,Marka=ArabaObject.Marka});
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRunTime { get; set; }
    }
}
#pragma warning restore 1591
