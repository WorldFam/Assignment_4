#pragma checksum "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d95ebe9b8391ab5160265c178220d12a2745d35b"
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
#line 3 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
           [Authorize(Policy = "SecurityLevel2")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                  _adult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                          AddNewAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.AddMarkupContent(8, "<div> &nbsp;</div>\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "container");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row ");
                __builder2.AddMarkupContent(13, "<div class=\"col-1\"><p class=\"my-1 mx-1 size\">First Name:</p></div>\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                                                         _adult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.FirstName = __value, _adult.FirstName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.AddMarkupContent(23, "<div class=\"col-1\"><p class=\"my-1 mx-1 size\">Last Name:</p></div>\r\n            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-5");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                                                          _adult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.LastName = __value, _adult.LastName))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.AddMarkupContent(33, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "row");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col");
                __Blazor.Assignment_4.Pages.AddAdult.TypeInference.CreateInputSelect_0(__builder2, 38, 39, "form-control", 40, 
#nullable restore
#line 25 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                           _adult.HairColor

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.HairColor = __value, _adult.HairColor)), 42, () => _adult.HairColor, 43, (__builder3) => {
                    __builder3.AddMarkupContent(44, "<option disabled selected>Select Available Hair Color</option>\r\n                    ");
                    __builder3.AddMarkupContent(45, "<option id=\"blond\" value=\"Blond\">Blond</option>\r\n                    ");
                    __builder3.AddMarkupContent(46, "<option id=\"red\" value=\"Red\">Red</option>\r\n                    ");
                    __builder3.AddMarkupContent(47, "<option class=\"brown\" value=\"Brown\">Brown</option>\r\n                    ");
                    __builder3.AddMarkupContent(48, "<option id=\"black\" value=\"Black\">Black</option>\r\n                    ");
                    __builder3.AddMarkupContent(49, "<option id=\"white\" value=\"White\">White</option>\r\n                    ");
                    __builder3.AddMarkupContent(50, "<option class=\"grey\" value=\"Grey\">Grey</option>\r\n                    ");
                    __builder3.AddMarkupContent(51, "<option class=\"blue\" value=\"Blue\">Blue</option>\r\n                    ");
                    __builder3.AddMarkupContent(52, "<option class=\"green\" value=\"Green\">Green</option>\r\n                    ");
                    __builder3.AddMarkupContent(53, "<option id=\"leverpostej\" value=\"Leverpostej\">Leverpostej</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col");
                __Blazor.Assignment_4.Pages.AddAdult.TypeInference.CreateInputSelect_1(__builder2, 57, 58, "form-control", 59, 
#nullable restore
#line 39 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                          _adult.EyeColor

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.EyeColor = __value, _adult.EyeColor)), 61, () => _adult.EyeColor, 62, (__builder3) => {
                    __builder3.AddMarkupContent(63, "<option disabled selected>Select Available Eye Color</option>\r\n                    ");
                    __builder3.AddMarkupContent(64, "<option class=\"brown\" value=\"Brown\">Brown</option>\r\n                    ");
                    __builder3.AddMarkupContent(65, "<option id=\"amber\" value=\"Amber\">Amber</option>\r\n                    ");
                    __builder3.AddMarkupContent(66, "<option id=\"hazel\" value=\"Hazel\">Hazel</option>\r\n                    ");
                    __builder3.AddMarkupContent(67, "<option class=\"grey\" value=\"Grey\">Grey</option>\r\n                    ");
                    __builder3.AddMarkupContent(68, "<option class=\"blue\" value=\"Blue\">Blue</option>\r\n                    ");
                    __builder3.AddMarkupContent(69, "<option class=\"green\" value=\"Green\">Green</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.AddMarkupContent(71, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "row");
                __builder2.AddMarkupContent(74, "<div class=\"col-1\"><label class=\"my-1 mx-4\">Age:</label></div>\r\n            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-5");
                __Blazor.Assignment_4.Pages.AddAdult.TypeInference.CreateInputNumber_2(__builder2, 77, 78, "form-control", 79, 
#nullable restore
#line 56 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                          _adult.Age

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Age = __value, _adult.Age)), 81, () => _adult.Age);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n            ");
                __builder2.AddMarkupContent(83, "<div class=\"col-1\"><label class=\"my-1 mr-2\">Weight:</label></div>\r\n            ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "col-5");
                __Blazor.Assignment_4.Pages.AddAdult.TypeInference.CreateInputNumber_3(__builder2, 86, 87, "1", 88, "form-control", 89, 
#nullable restore
#line 62 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                   _adult.Weight

#line default
#line hidden
#nullable disable
                , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Weight = __value, _adult.Weight)), 91, () => _adult.Weight);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n        ");
                __builder2.AddMarkupContent(93, "<div> &nbsp;</div>\r\n        ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "row");
                __builder2.AddMarkupContent(96, "<div class=\"col-1\"><label class=\"my-1 mx-4\">Height:</label></div>\r\n            ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-5");
                __Blazor.Assignment_4.Pages.AddAdult.TypeInference.CreateInputNumber_4(__builder2, 99, 100, "form-control", 101, 
#nullable restore
#line 68 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                         _adult.Height

#line default
#line hidden
#nullable disable
                , 102, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.Height = __value, _adult.Height)), 103, () => _adult.Height);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.AddMarkupContent(105, "<div class=\"col-2\"><label>Select gender:</label></div>");
#nullable restore
#line 70 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
             foreach (var item in new string[] { "Male","Female"})
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "form-check col-2");
                __builder2.OpenElement(108, "input");
                __builder2.AddAttribute(109, "type", "radio");
                __builder2.AddAttribute(110, "name", "technology");
                __builder2.AddAttribute(111, "id", 
#nullable restore
#line 73 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                                     item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(112, "value", 
#nullable restore
#line 73 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                                                   item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                                                                     RadioSelection

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "checked", 
#nullable restore
#line 73 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                                                                                               RadioValue.Equals(item,StringComparison.OrdinalIgnoreCase)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                          ");
                __builder2.OpenElement(116, "label");
                __builder2.AddAttribute(117, "for", 
#nullable restore
#line 74 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                       item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(118, 
#nullable restore
#line 74 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                              item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 76 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n        ");
                __builder2.OpenElement(120, "div");
                __builder2.AddMarkupContent(121, "<div> &nbsp;</div>\r\n            ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "row");
                __builder2.AddMarkupContent(124, "<div class=\"col-1\"><label>Job Title:</label></div>\r\n                ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "col-8");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(127);
                __builder2.AddAttribute(128, "class", "form-control");
                __builder2.AddAttribute(129, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 82 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                            _adult.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(130, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _adult.JobTitle = __value, _adult.JobTitle))));
                __builder2.AddAttribute(131, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _adult.JobTitle));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n                ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "col-3");
                __builder2.OpenElement(135, "button");
                __builder2.AddAttribute(136, "class", "btn btn-primary mb-2 button1");
                __builder2.AddAttribute(137, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
                                                                            OnSubmit

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "type", "submit");
                __builder2.AddContent(139, "Create");
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
#line 90 "C:\Users\mirek\RiderProjects\Assignment_4\Assignment 4\Pages\AddAdult.razor"
           private Adult _adult = new Adult();


    private async Task AddNewAdult()
    {
       await FileContext.AddAdultAsync(_adult);
        NavigationManager.NavigateTo("/AdultList");
    }

    string RadioValue = "";
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
        _adult.Sex = RadioValue;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICloudService FileContext { get; set; }
    }
}
namespace __Blazor.Assignment_4.Pages.AddAdult
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