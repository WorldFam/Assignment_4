#pragma checksum "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f836f62006da342e370b22911f634f0635ee58"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\_Imports.razor"
using Assignment_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\_Imports.razor"
using Assignment_3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
using System.Xml;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditAdult/{value}")]
    public partial class EditAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "﻿\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                  adultItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                             EditAdultAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.AddMarkupContent(10, "<div> &nbsp;</div>\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "container");
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "row ");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.AddMarkupContent(17, "<div class=\"col-1\"><p class=\"my-1 mx-1 size\">First Name:</p></div>\r\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-5");
                __builder2.AddContent(20, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "type", "text");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                                                         adultItem.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.FirstName = __value, adultItem.FirstName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultItem.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.AddMarkupContent(28, "<div class=\"col-1\"><p class=\"my-1 mx-1 size\">Last Name:</p></div>\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-5");
                __builder2.AddContent(31, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "type", "text");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                                                          adultItem.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.LastName = __value, adultItem.LastName))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultItem.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.AddMarkupContent(40, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "row");
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "col");
                __builder2.AddMarkupContent(46, "\r\n                ");
                __Blazor.Assignment_3.Pages.EditAdult.TypeInference.CreateInputSelect_0(__builder2, 47, 48, "form-control", 49, 
#nullable restore
#line 25 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                           adultItem.HairColor

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.HairColor = __value, adultItem.HairColor)), 51, () => adultItem.HairColor, 52, (__builder3) => {
                    __builder3.AddMarkupContent(53, "\r\n                    ");
                    __builder3.AddMarkupContent(54, "<option disabled selected>Select Available Hair Color</option>\r\n                    ");
                    __builder3.AddMarkupContent(55, "<option id=\"blond\" value=\"Blond\">Blond</option>\r\n                    ");
                    __builder3.AddMarkupContent(56, "<option id=\"red\" value=\"Red\">Red</option>\r\n                    ");
                    __builder3.AddMarkupContent(57, "<option class=\"brown\" value=\"Brown\">Brown</option>\r\n                    ");
                    __builder3.AddMarkupContent(58, "<option id=\"black\" value=\"Black\">Black</option>\r\n                    ");
                    __builder3.AddMarkupContent(59, "<option id=\"white\" value=\"White\">White</option>\r\n                    ");
                    __builder3.AddMarkupContent(60, "<option class=\"grey\" value=\"Grey\">Grey</option>\r\n                    ");
                    __builder3.AddMarkupContent(61, "<option class=\"blue\" value=\"Blue\">Blue</option>\r\n                    ");
                    __builder3.AddMarkupContent(62, "<option class=\"green\" value=\"Green\">Green</option>\r\n                    ");
                    __builder3.AddMarkupContent(63, "<option id=\"leverpostej\" value=\"Leverpostej\">Leverpostej</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(64, "   \r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col");
                __builder2.AddMarkupContent(68, "\r\n                ");
                __Blazor.Assignment_3.Pages.EditAdult.TypeInference.CreateInputSelect_1(__builder2, 69, 70, "form-control", 71, 
#nullable restore
#line 39 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                          adultItem.EyeColor

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.EyeColor = __value, adultItem.EyeColor)), 73, () => adultItem.EyeColor, 74, (__builder3) => {
                    __builder3.AddMarkupContent(75, "\r\n                    ");
                    __builder3.AddMarkupContent(76, "<option disabled selected>Select Available Eye Color</option>\r\n                    ");
                    __builder3.AddMarkupContent(77, "<option class=\"brown\" value=\"Brown\">Brown</option>\r\n                    ");
                    __builder3.AddMarkupContent(78, "<option id=\"amber\" value=\"Aamber\">Amber</option>\r\n                    ");
                    __builder3.AddMarkupContent(79, "<option id=\"hazel\" value=\"Hazel\">Hazel</option>\r\n                    ");
                    __builder3.AddMarkupContent(80, "<option class=\"grey\" value=\"Grey\">Grey</option>\r\n                    ");
                    __builder3.AddMarkupContent(81, "<option class=\"blue\" value=\"Blue\">Blue</option>\r\n                    ");
                    __builder3.AddMarkupContent(82, "<option class=\"green\" value=\"Green\">Green</option>\r\n                ");
                }
                );
                __builder2.AddMarkupContent(83, "       \r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.AddMarkupContent(86, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "row");
                __builder2.AddMarkupContent(89, "\r\n            ");
                __builder2.AddMarkupContent(90, "<div class=\"col-1\">\r\n                <label class=\"my-1 mx-4\">Age:</label>\r\n            </div>\r\n            ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col-5");
                __builder2.AddMarkupContent(93, "\r\n                ");
                __Blazor.Assignment_3.Pages.EditAdult.TypeInference.CreateInputNumber_2(__builder2, 94, 95, "form-control", 96, 
#nullable restore
#line 56 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                          adultItem.Age

#line default
#line hidden
#nullable disable
                , 97, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Age = __value, adultItem.Age)), 98, () => adultItem.Age);
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n            ");
                __builder2.AddMarkupContent(101, "<div class=\"col-1\">\r\n                <label class=\"my-1 mr-2\">Weight:</label>\r\n            </div>\r\n            ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-5");
                __builder2.AddMarkupContent(104, "\r\n                ");
                __Blazor.Assignment_3.Pages.EditAdult.TypeInference.CreateInputNumber_3(__builder2, 105, 106, "1", 107, "form-control", 108, 
#nullable restore
#line 62 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                   adultItem.Weight

#line default
#line hidden
#nullable disable
                , 109, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Weight = __value, adultItem.Weight)), 110, () => adultItem.Weight);
                __builder2.AddMarkupContent(111, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.AddMarkupContent(114, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "row");
                __builder2.AddMarkupContent(117, "\r\n            ");
                __builder2.AddMarkupContent(118, "<div class=\"col-1\"><label class=\"my-1 mx-4\">Height:</label></div>\r\n            ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "col-5");
                __Blazor.Assignment_3.Pages.EditAdult.TypeInference.CreateInputNumber_4(__builder2, 121, 122, "form-control", 123, 
#nullable restore
#line 68 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                         adultItem.Height

#line default
#line hidden
#nullable disable
                , 124, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Height = __value, adultItem.Height)), 125, () => adultItem.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n            ");
                __builder2.AddMarkupContent(127, "<div class=\"col-2\"><label>Select gender:</label></div>\r\n");
#nullable restore
#line 70 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
             foreach (var item in new string[] { "Male","Female"})
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(128, "                            ");
                __builder2.OpenElement(129, "div");
                __builder2.AddAttribute(130, "class", "form-check col-2");
                __builder2.AddMarkupContent(131, "\r\n                                ");
                __builder2.OpenElement(132, "input");
                __builder2.AddAttribute(133, "type", "radio");
                __builder2.AddAttribute(134, "name", "technology");
                __builder2.AddAttribute(135, "id", 
#nullable restore
#line 73 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                                           item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(136, "value", 
#nullable restore
#line 73 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                                                         item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(137, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                                                                          RadioSelection

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "checked", 
#nullable restore
#line 73 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                                                                                                    RadioValue.Equals(item, StringComparison.OrdinalIgnoreCase)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                                ");
                __builder2.OpenElement(140, "label");
                __builder2.AddAttribute(141, "for", 
#nullable restore
#line 74 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                             item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(142, 
#nullable restore
#line 74 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                    item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n");
#nullable restore
#line 76 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(145, "        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n        ");
                __builder2.OpenElement(147, "div");
                __builder2.AddMarkupContent(148, "\r\n            ");
                __builder2.AddMarkupContent(149, "<div> &nbsp;</div>\r\n            ");
                __builder2.OpenElement(150, "div");
                __builder2.AddAttribute(151, "class", "row");
                __builder2.AddMarkupContent(152, "\r\n                ");
                __builder2.AddMarkupContent(153, "<div class=\"col-1\"><label>Job Title:</label></div>\r\n                ");
                __builder2.OpenElement(154, "div");
                __builder2.AddAttribute(155, "class", "col-8");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(156);
                __builder2.AddAttribute(157, "class", "form-control");
                __builder2.AddAttribute(158, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 82 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                            adultItem.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(159, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.JobTitle = __value, adultItem.JobTitle))));
                __builder2.AddAttribute(160, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultItem.JobTitle));
                __builder2.CloseComponent();
                __builder2.AddContent(161, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\r\n                ");
                __builder2.OpenElement(163, "div");
                __builder2.AddAttribute(164, "class", "col-3");
                __builder2.AddMarkupContent(165, "\r\n                    ");
                __builder2.OpenElement(166, "button");
                __builder2.AddAttribute(167, "class", "btn btn-primary mb-2 button1");
                __builder2.AddAttribute(168, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
                                                                            OnSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(169, "type", "submit");
                __builder2.AddContent(170, "Change");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(171, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(173, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(174, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\Ceslov\RiderProjects\Assignment 3 API\Assignment 3\Pages\EditAdult.razor"
       

    public Adult adultItem = new Adult();
    public Adult adult;

    protected override async Task OnInitializedAsync()
    {
        var stringId = value;
        int Id = int.Parse(stringId);
        adultItem = await FileContext.GetAdultByIdAsync(Id);
        adult = adultItem;
    }
    
    private async Task EditAdultAsync()
    {
        await FileContext.UpdateAdultAsync(adult);
        Console.Write(adult);
        NavigationManager.NavigateTo("/AdultList");
    }
    [Parameter]
    public string value { get; set; }
     
    
    string RadioValue = "M" ;
    void RadioSelection(ChangeEventArgs args)
    {
        RadioValue = args.Value.ToString();
        if (RadioValue.Equals("Female"))
        {
            RadioValue = "F";
        }
        else if (RadioValue.Equals("Male"))
        {
            RadioValue = "M";
        }
    }

    void OnSubmit()
    {
        adultItem.Sex = RadioValue;
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudService FileContext { get; set; }
    }
}
namespace __Blazor.Assignment_3.Pages.EditAdult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591