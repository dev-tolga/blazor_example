#pragma checksum "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eb26b54c7217d44dd3f7dc5716a419b8c79e060"
// <auto-generated/>
#pragma warning disable 1591
namespace OgrenciServis.Pages.Veli
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
#line 4 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
using OgrenciServis.Component.BaseComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
using OgrenciServis.Component.CustomComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
using OgrenciServis.Component.CustomComponent.Card;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
using OgrenciServis.Component.CustomComponent.Popup;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/veli")]
    public partial class VeliPage : VeliPageBase
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
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.LabelComponent>(12);
                        __builder4.AddAttribute(13, "ClassName", "col-sm-2 col-form-label");
                        __builder4.AddAttribute(14, "Title", "Okul");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(15, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(16);
                        __builder4.AddAttribute(17, "ClassName", "col-sm-9");
                        __builder4.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(19, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.ComboBoxComponent>(20);
                            __builder5.AddAttribute(21, "ObjectList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.Object>>(
#nullable restore
#line 16 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                               okulList.Cast<object>().ToList()

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(22, "KolonNames", "OkulAd");
                            __builder5.AddAttribute(23, "OnChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                OnChangedOkul

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(24, "SelectedChangedID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                                                  selectedOkulId

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(25, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(26, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(27);
                        __builder4.AddAttribute(28, "ClassName", "col-sm-1");
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(30, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.ButtonComponent>(31);
                            __builder5.AddAttribute(32, "ButtonName", "");
                            __builder5.AddAttribute(33, "ClassName", "btn btn-warning btn-block");
                            __builder5.AddAttribute(34, "StyleStr", "border:1px solid #ced4da;background-color: #cc5333;");
                            __builder5.AddAttribute(35, "IsPopupBtn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                             true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(36, "DataTargetStr", "OkulPopupId");
                            __builder5.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(38, "\r\n                    ");
                                __builder6.OpenComponent<OgrenciServis.Component.BaseComponent.ITagComponent>(39);
                                __builder6.AddAttribute(40, "ClassName", "oi iconify");
                                __builder6.AddAttribute(41, "DataIconName", "emojione:school");
                                __builder6.AddAttribute(42, "FontSize", "20px");
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(43, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(44, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(45, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(47);
                    __builder3.AddAttribute(48, "ClassName", "form-group row");
                    __builder3.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(50, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.LabelComponent>(51);
                        __builder4.AddAttribute(52, "ClassName", "col-sm-2 col-form-label");
                        __builder4.AddAttribute(53, "Title", "Öğrenci");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(54, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(55);
                        __builder4.AddAttribute(56, "ClassName", "col-sm-9");
                        __builder4.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(58, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.ComboBoxComponent>(59);
                            __builder5.AddAttribute(60, "ObjectList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.Object>>(
#nullable restore
#line 31 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                               ogrenciListByOkul.Cast<object>().ToList()

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(61, "KolonNames", "AdSoyad");
                            __builder5.AddAttribute(62, "OnChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.ChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                          onChangedOgrenci

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(63, "SelectedChangedID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 31 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                                                               selectedOgrenciId

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(64, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(65, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(66);
                        __builder4.AddAttribute(67, "ClassName", "col-sm-1");
                        __builder4.AddAttribute(68, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(69, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.ButtonComponent>(70);
                            __builder5.AddAttribute(71, "ButtonName", "");
                            __builder5.AddAttribute(72, "ClassName", "btn btn-warning btn-block");
                            __builder5.AddAttribute(73, "StyleStr", "border:1px solid #ced4da;background-color: #cc5333;");
                            __builder5.AddAttribute(74, "IsPopupBtn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 37 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                             true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(75, "DataTargetStr", "OgrenciKaydetPopupId");
                            __builder5.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(77, "\r\n                    ");
                                __builder6.OpenComponent<OgrenciServis.Component.BaseComponent.ITagComponent>(78);
                                __builder6.AddAttribute(79, "ClassName", "oi iconify");
                                __builder6.AddAttribute(80, "DataIconName", "flat-color-icons:graduation-cap");
                                __builder6.AddAttribute(81, "FontSize", "20px");
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(82, "\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(83, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(84, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(85, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(86);
                    __builder3.AddAttribute(87, "ClassName", "form-group row");
                    __builder3.AddAttribute(88, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(89, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(90);
                        __builder4.AddAttribute(91, "ClassName", "col-sm-5");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(92, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(93);
                        __builder4.AddAttribute(94, "ClassName", "col-sm-5");
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(95, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(96);
                        __builder4.AddAttribute(97, "ClassName", "col-sm-2");
                        __builder4.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(99, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.ButtonComponent>(100);
                            __builder5.AddAttribute(101, "ClassName", "btn btn-success btn-block");
                            __builder5.AddAttribute(102, "ButtonName", "Ekle");
                            __builder5.AddAttribute(103, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                  Ekle

#line default
#line hidden
#nullable disable
                            )));
                            __builder5.AddAttribute(104, "StyleStr", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                   EkleBtnStyleStr

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(105, "IsPopupBtn", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                                                false

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(106, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(107, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(108, "\r\n        ");
                    __builder3.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(109);
                    __builder3.AddAttribute(110, "ClassName", "form-group row");
                    __builder3.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(112, "\r\n            ");
                        __builder4.OpenComponent<OgrenciServis.Component.BaseComponent.DivComponent>(113);
                        __builder4.AddAttribute(114, "ClassName", "col-sm-12");
                        __builder4.AddAttribute(115, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(116, "\r\n                ");
                            __builder5.OpenComponent<OgrenciServis.Component.BaseComponent.TableComponent>(117);
                            __builder5.AddAttribute(118, "KolonNames", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.Dictionary<System.String, System.String>>(
#nullable restore
#line 52 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                            kolonVeliIsimleri

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(119, "ObjectList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.Object>>(
#nullable restore
#line 52 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                           VeliList.Cast<object>().ToList()

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(120, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(121, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(122, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n    ");
                __builder2.OpenComponent<OgrenciServis.Component.CustomComponent.Card.CardFooterComponent>(124);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(125, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(126, "\r\n\r\n");
            __builder.OpenComponent<OgrenciServis.Component.CustomComponent.Popup.PopupStatusComponent>(127);
            __builder.AddAttribute(128, "StatusDurum", "alert alert-success");
            __builder.AddAttribute(129, "Title", "Kayıt işlemi başarılı bir şekilde gerçekleştirilmiştir.");
            __builder.AddAttribute(130, "ModalId", "modalKayitBasarili");
            __builder.AddAttribute(131, "zIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 59 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                                                             1051

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(132, "\r\n");
            __builder.OpenComponent<OgrenciServis.Component.CustomComponent.Popup.PopupStatusComponent>(133);
            __builder.AddAttribute(134, "StatusDurum", "alert alert-danger");
            __builder.AddAttribute(135, "Title", "Lütfen öğrenci secimi yapınız");
            __builder.AddAttribute(136, "ModalId", "modalKayitAlert");
            __builder.AddAttribute(137, "zIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 60 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                               1051

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(138, "\r\n");
            __builder.OpenComponent<OgrenciServis.Pages.Veli.VeliPagePopupComponent>(139);
            __builder.AddAttribute(140, "ModalName", "OkulPopupId");
            __builder.AddAttribute(141, "Ekle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                      KaydetOkul

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(142, "zIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 61 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                        1050

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(143, (__value) => {
#nullable restore
#line 61 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                        veliPagePopupComponent = (OgrenciServis.Pages.Veli.VeliPagePopupComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(144, "\r\n");
            __builder.OpenComponent<OgrenciServis.Pages.Veli.VeliPageOgrenciPopupComponent>(145);
            __builder.AddAttribute(146, "ModalName", "OgrenciKaydetPopupId");
            __builder.AddAttribute(147, "zIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 62 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                             1050

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(148, "OkulListesi", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<OgrenciServis.Data.Okul>>(
#nullable restore
#line 62 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                                okulList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(149, "PopuptanOgrenciEkle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                                                                                                               PopuptanOgrenciKaydet

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(150, (__value) => {
#nullable restore
#line 62 "C:\Users\Sercan YILDIRIM\source\repos\OgrenciServis\OgrenciServis\Pages\Veli\VeliPage.razor"
                                                                      veliPageOgrenciPopupComponent = (OgrenciServis.Pages.Veli.VeliPageOgrenciPopupComponent)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRunTime { get; set; }
    }
}
#pragma warning restore 1591
