#pragma checksum "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39d91eba79710d298b0c61677f95e0a260576c27"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ToDoList.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/_Imports.razor"
using ToDoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/_Imports.razor"
using ToDoList.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/Users/anthonyheitzeberg/Desktop/Pirple Classes/OOP with CSharp/ToDoList/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
