#pragma checksum "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f836f62006da342e370b22911f634f0635ee58"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment_4.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\_Imports.razor"
using Assignment_4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\_Imports.razor"
using Assignment_4.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
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
#line 11 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                  adultItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                             EditAdultAsync

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.AddMarkupContent(9, "<div> &nbsp;</div>\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "container");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row ");
                __builder2.AddMarkupContent(14, "<div class=\"col-1\"><p class=\"my-1 mx-1 size\">First Name:</p></div>\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "type", "text");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                                                         adultItem.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.FirstName = __value, adultItem.FirstName))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultItem.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.AddMarkupContent(24, "<div class=\"col-1\"><p class=\"my-1 mx-1 size\">Last Name:</p></div>\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "type", "text");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                                                          adultItem.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.LastName = __value, adultItem.LastName))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultItem.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.AddMarkupContent(34, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "row");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col");
                __Blazor.Assignment_4.Pages.EditAdult.TypeInference.CreateInputSelect_0(__builder2, 39, 40, "form-control", 41, 
#nullable restore
#line 25 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                           adultItem.HairColor

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.HairColor = __value, adultItem.HairColor)), 43, () => adultItem.HairColor, 44, (__builder3) => {
                    __builder3.AddMarkupContent(45, "<option disabled selected>Select Available Hair Color</option>\r\n                    ");
                    __builder3.AddMarkupContent(46, "<option id=\"blond\" value=\"Blond\">Blond</option>\r\n                    ");
                    __builder3.AddMarkupContent(47, "<option id=\"red\" value=\"Red\">Red</option>\r\n                    ");
                    __builder3.AddMarkupContent(48, "<option class=\"brown\" value=\"Brown\">Brown</option>\r\n                    ");
                    __builder3.AddMarkupContent(49, "<option id=\"black\" value=\"Black\">Black</option>\r\n                    ");
                    __builder3.AddMarkupContent(50, "<option id=\"white\" value=\"White\">White</option>\r\n                    ");
                    __builder3.AddMarkupContent(51, "<option class=\"grey\" value=\"Grey\">Grey</option>\r\n                    ");
                    __builder3.AddMarkupContent(52, "<option class=\"blue\" value=\"Blue\">Blue</option>\r\n                    ");
                    __builder3.AddMarkupContent(53, "<option class=\"green\" value=\"Green\">Green</option>\r\n                    ");
                    __builder3.AddMarkupContent(54, "<option id=\"leverpostej\" value=\"Leverpostej\">Leverpostej</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col");
                __Blazor.Assignment_4.Pages.EditAdult.TypeInference.CreateInputSelect_1(__builder2, 58, 59, "form-control", 60, 
#nullable restore
#line 39 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                          adultItem.EyeColor

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.EyeColor = __value, adultItem.EyeColor)), 62, () => adultItem.EyeColor, 63, (__builder3) => {
                    __builder3.AddMarkupContent(64, "<option disabled selected>Select Available Eye Color</option>\r\n                    ");
                    __builder3.AddMarkupContent(65, "<option class=\"brown\" value=\"Brown\">Brown</option>\r\n                    ");
                    __builder3.AddMarkupContent(66, "<option id=\"amber\" value=\"Aamber\">Amber</option>\r\n                    ");
                    __builder3.AddMarkupContent(67, "<option id=\"hazel\" value=\"Hazel\">Hazel</option>\r\n                    ");
                    __builder3.AddMarkupContent(68, "<option class=\"grey\" value=\"Grey\">Grey</option>\r\n                    ");
                    __builder3.AddMarkupContent(69, "<option class=\"blue\" value=\"Blue\">Blue</option>\r\n                    ");
                    __builder3.AddMarkupContent(70, "<option class=\"green\" value=\"Green\">Green</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n        ");
                __builder2.AddMarkupContent(72, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "row");
                __builder2.AddMarkupContent(75, "<div class=\"col-1\"><label class=\"my-1 mx-4\">Age:</label></div>\r\n            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "col-5");
                __Blazor.Assignment_4.Pages.EditAdult.TypeInference.CreateInputNumber_2(__builder2, 78, 79, "form-control", 80, 
#nullable restore
#line 56 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                          adultItem.Age

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Age = __value, adultItem.Age)), 82, () => adultItem.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n            ");
                __builder2.AddMarkupContent(84, "<div class=\"col-1\"><label class=\"my-1 mr-2\">Weight:</label></div>\r\n            ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-5");
                __Blazor.Assignment_4.Pages.EditAdult.TypeInference.CreateInputNumber_3(__builder2, 87, 88, "1", 89, "form-control", 90, 
#nullable restore
#line 62 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                   adultItem.Weight

#line default
#line hidden
#nullable disable
                , 91, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Weight = __value, adultItem.Weight)), 92, () => adultItem.Weight);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n        ");
                __builder2.AddMarkupContent(94, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "row");
                __builder2.AddMarkupContent(97, "<div class=\"col-1\"><label class=\"my-1 mx-4\">Height:</label></div>\r\n            ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "col-5");
                __Blazor.Assignment_4.Pages.EditAdult.TypeInference.CreateInputNumber_4(__builder2, 100, 101, "form-control", 102, 
#nullable restore
#line 68 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                         adultItem.Height

#line default
#line hidden
#nullable disable
                , 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.Height = __value, adultItem.Height)), 104, () => adultItem.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n            ");
                __builder2.AddMarkupContent(106, "<div class=\"col-2\"><label>Select gender:</label></div>");
#nullable restore
#line 70 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
             foreach (var item in new string[] { "Male","Female"})
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "form-check col-2");
                __builder2.OpenElement(109, "input");
                __builder2.AddAttribute(110, "type", "radio");
                __builder2.AddAttribute(111, "name", "technology");
                __builder2.AddAttribute(112, "id", 
#nullable restore
#line 73 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                                           item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(113, "value", 
#nullable restore
#line 73 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                                                         item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(114, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                                                                          RadioSelection

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "checked", 
#nullable restore
#line 73 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                                                                                                    RadioValue.Equals(item, StringComparison.OrdinalIgnoreCase)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                                ");
                __builder2.OpenElement(117, "label");
                __builder2.AddAttribute(118, "for", 
#nullable restore
#line 74 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                             item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(119, 
#nullable restore
#line 74 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                    item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 76 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n        ");
                __builder2.OpenElement(121, "div");
                __builder2.AddMarkupContent(122, "<div> &nbsp;</div>\r\n            ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "row");
                __builder2.AddMarkupContent(125, "<div class=\"col-1\"><label>Job Title:</label></div>\r\n                ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "col-8");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(128);
                __builder2.AddAttribute(129, "class", "form-control");
                __builder2.AddAttribute(130, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 82 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                            adultItem.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(131, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultItem.JobTitle = __value, adultItem.JobTitle))));
                __builder2.AddAttribute(132, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => adultItem.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "col-3");
                __builder2.OpenElement(136, "button");
                __builder2.AddAttribute(137, "class", "btn btn-primary mb-2 button1");
                __builder2.AddAttribute(138, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
                                                                            OnSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(139, "type", "submit");
                __builder2.AddContent(140, "Change");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\EditAdult.razor"
       

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
namespace __Blazor.Assignment_4.Pages.EditAdult
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
