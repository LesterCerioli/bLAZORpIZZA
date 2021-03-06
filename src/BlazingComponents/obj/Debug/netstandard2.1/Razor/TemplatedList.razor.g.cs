#pragma checksum "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcb2d5d2ccfb30647a269e3f8ce58810ffd9fe6e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public partial class TemplatedList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
 if (items == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 5 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
     Loading

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 5 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
            
}
else if (items.Count == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 9 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
     Empty

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 9 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
          
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "list-group" + " " + (
#nullable restore
#line 13 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
                            ListGroupClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 14 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
         foreach (var item in items)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "list-group-item");
            __builder.AddMarkupContent(9, "\n                ");
            __builder.AddContent(10, 
#nullable restore
#line 17 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
                 Item(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
#nullable restore
#line 19 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
#nullable restore
#line 21 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingComponents\TemplatedList.razor"
       
    List<TItem> items;

    [Parameter] public Func<Task<List<TItem>>> Loader { get; set; }
    [Parameter] public RenderFragment Loading { get; set; }
    [Parameter] public RenderFragment Empty { get; set; }
    [Parameter] public RenderFragment<TItem> Item { get; set; }
    [Parameter] public string ListGroupClass { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        items = await Loader();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
