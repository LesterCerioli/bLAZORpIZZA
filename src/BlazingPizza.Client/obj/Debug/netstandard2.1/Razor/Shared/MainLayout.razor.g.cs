#pragma checksum "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dc941b211b13df5249ce600c18fec0921ea08ae"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 10 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
#line 11 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingPizza.ComponentsLibrary.Map;

#line default
#line hidden
#line 12 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\_Imports.razor"
using BlazingComponents;

#line default
#line hidden
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-bar");
            __builder.AddMarkupContent(2, "\n    <img class=\"logo\" src=\"img/logo.svg\">\n\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(3);
            __builder.AddAttribute(4, "href", "");
            __builder.AddAttribute(5, "class", "nav-tab");
            __builder.AddAttribute(6, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#line 6 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\MainLayout.razor"
                                            NavLinkMatch.All

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\n        <img src=\"img/pizza-slice.svg\">\n        ");
                __builder2.AddMarkupContent(9, "<div>Get Pizza</div>\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\n\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "href", "myorders");
            __builder.AddAttribute(13, "class", "nav-tab");
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\n        <img src=\"img/bike.svg\">\n        ");
                __builder2.AddMarkupContent(16, "<div>My Orders</div>\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\n\n    ");
            __builder.OpenComponent<BlazingPizza.Client.Shared.LoginDisplay>(18);
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "content");
            __builder.AddMarkupContent(23, "\n    ");
            __builder.AddContent(24, 
#line 20 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Shared\MainLayout.razor"
     Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(25, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591