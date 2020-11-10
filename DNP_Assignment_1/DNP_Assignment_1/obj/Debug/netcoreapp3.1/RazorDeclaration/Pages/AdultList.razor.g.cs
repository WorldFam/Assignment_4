#pragma checksum "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\Pages\AdultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dadcffc61ee770a9a629564779d8f0c4d110f3c7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNP_Assignment_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\_Imports.razor"
using DNP_Assignment_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\_Imports.razor"
using DNP_Assignment_1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\Pages\AdultList.razor"
using Assignment_1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\Pages\AdultList.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\Pages\AdultList.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AdultList")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "C:\Users\Ceslov\RiderProjects\DNP_Assignment_1\DNP_Assignment_1\Pages\AdultList.razor"
       
    private IList<Adult> todosToShow;
    private IList<Adult> allTodos;

    private string filterByName;
    private string error;
    
    [CascadingParameter] Task<AuthenticationState> authenticationStateTask { get; set; }
    
    private void FilterByName(ChangeEventArgs changeEventArgs)
    {
        try
        {
            filterByName = changeEventArgs.Value.ToString();
        } catch (Exception e) { }
        ExecuteFilter();
    }
    
    private void ExecuteFilter() {
        todosToShow = allTodos.Where(t => 
            (filterByName != "" && t.FirstName.Equals(filterByName,StringComparison.OrdinalIgnoreCase)  || filterByName == "") 
            ).ToList();
    }


    protected override async Task OnInitializedAsync() {
        allTodos = FileContext.GetAdults();
        todosToShow = allTodos;
    }

    private async void RemoveTodo(int todoId)
    {
        var authState = await authenticationStateTask;
        var user = authState.User;
        if (user.Identity.IsAuthenticated)
        {
        Adult todoToRemove = todosToShow.First(t => t.Id == todoId);
        FileContext.RemoveAdult(todoId);
        todosToShow.Remove(todoToRemove);
        }
        else
        {
            error = "Please Login!";
            Console.WriteLine("You're not logged in.");
        }
    }
    
    private async void EditAdult(int value)
    {
        
        var authState = await authenticationStateTask;
        var user = authState.User;
        if (user.Identity.IsAuthenticated)
        {
        string result;
        result = value.ToString();
        NavigationManager.NavigateTo($"/EditAdult/{result}");
        }
        else
        {
            error = "Please Login!";
            Console.WriteLine("You're not logged in.");
        }
    }
  
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileContext FileContext { get; set; }
    }
}
#pragma warning restore 1591