#pragma checksum "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001d0acd72f5e0fb732262d0fe9c23486df66339"
// <auto-generated/>
#pragma warning disable 1591
namespace OgrenciServis.Pages.Hostes
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
#line 4 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
using OgrenciServis.Component.BaseComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
using OgrenciServis.Component.CustomComponent.Card;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hostes")]
    public partial class HostesPage : HostesPageBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<OgrenciServis.Component.CustomComponent.Card.CardComponent>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<OgrenciServis.Component.CustomComponent.Card.CardHeaderComponent>(3);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<OgrenciServis.Component.CustomComponent.Card.CardBodyComponent>(5);
                __builder2.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(8);
                    __builder3.AddAttribute(9, "ClassName", "form-group row");
                    __builder3.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(11, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(12);
                        __builder4.AddAttribute(13, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(15, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.ComboBoxComponent>(16);
                            __builder5.AddAttribute(17, "ObjectList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.Object>>(
#nullable restore
#line 13 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
                                               ArabaList.Cast<object>().ToList()

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(18, "KolonNames", "ArabaPlaka");
                            __builder5.AddAttribute(19, "OnChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
                                              OnChangedAraba

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(20, "SelectedChangedID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
                                                      SelectedArabaId

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(21, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(22, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(23, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(24);
                    __builder3.AddAttribute(25, "ClassName", "form-group row");
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(27, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(28);
                        __builder4.AddAttribute(29, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(31, "\r\n                ");
                            __builder5.OpenElement(32, "input");
                            __builder5.AddAttribute(33, "type", "text");
                            __builder5.AddAttribute(34, "class", "form-control btn-block");
                            __builder5.AddAttribute(35, "placeholder", "Hostes adını giriniz.");
                            __builder5.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
                                     hostesObject.HostesAd

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(37, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hostesObject.HostesAd = __value, hostesObject.HostesAd));
                            __builder5.SetUpdatesAttributeName("value");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(38, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(39, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(41);
                    __builder3.AddAttribute(42, "ClassName", "form-group row");
                    __builder3.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(44, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(45);
                        __builder4.AddAttribute(46, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(48, "\r\n                ");
                            __builder5.OpenElement(49, "input");
                            __builder5.AddAttribute(50, "type", "text");
                            __builder5.AddAttribute(51, "class", "form-control btn-block");
                            __builder5.AddAttribute(52, "placeholder", "Hostes soyadını giriniz.");
                            __builder5.AddAttribute(53, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
                                     hostesObject.HostesSoyad

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(54, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hostesObject.HostesSoyad = __value, hostesObject.HostesSoyad));
                            __builder5.SetUpdatesAttributeName("value");
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(55, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(58);
                    __builder3.AddAttribute(59, "ClassName", "form-group row");
                    __builder3.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(61, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(62);
                        __builder4.AddAttribute(63, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(65, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.ButtonComponent>(66);
                            __builder5.AddAttribute(67, "ClassName", "btn btn-success float-right");
                            __builder5.AddAttribute(68, "ButtonName", "Kaydet");
                            __builder5.AddAttribute(69, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
                                          HostesKaydet

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(70, "IsPopupBtn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 42 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
                                             false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(71, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(72, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(74);
                    __builder3.AddAttribute(75, "ClassName", "form-group row");
                    __builder3.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(77, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(78);
                        __builder4.AddAttribute(79, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(81, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.TableComponent>(82);
                            __builder5.AddAttribute(83, "KolonNames", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 47 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
                                            kolonVeliIsimleri

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(84, "ObjectList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.Object>>(
#nullable restore
#line 48 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Hostes\HostesPage.razor"
                                            hostesListesi.Cast<object>().ToList()

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(85, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(86, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(87, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n    ");
                __builder2.OpenComponent<OgrenciServis.Component.CustomComponent.Card.CardFooterComponent>(89);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRunTime { get; set; }
    }
}
#pragma warning restore 1591
