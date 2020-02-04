#pragma checksum "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\MyOrders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "393ed1ff47b3024a37b95b0a5d1f4eec240cf15d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingPizza.Client.Pages
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
#line 3 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\MyOrders.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/myorders")]
    public partial class MyOrders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\n    ");
            __Blazor.BlazingPizza.Client.Pages.MyOrders.TypeInference.CreateTemplatedList_0(__builder, 3, 4, 
#line 6 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\MyOrders.razor"
                           LoadOrders

#line default
#line hidden
            , 5, "orders-list", 6, (__builder2) => {
                __builder2.AddContent(7, "Loading...");
            }
            , 8, (__builder2) => {
                __builder2.AddMarkupContent(9, "\n            ");
                __builder2.AddMarkupContent(10, "<h2>No orders placed</h2>\n            ");
                __builder2.AddMarkupContent(11, "<a class=\"btn btn-success\" href>Order some pizza</a>\n        ");
            }
            , 12, (item) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col");
                __builder2.AddMarkupContent(16, "\n                ");
                __builder2.OpenElement(17, "h5");
                __builder2.AddContent(18, 
#line 14 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\MyOrders.razor"
                     item.Order.CreatedTime.ToLongDateString()

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\n                Items:\n                ");
                __builder2.OpenElement(20, "strong");
                __builder2.AddContent(21, 
#line 16 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\MyOrders.razor"
                         item.Order.Pizzas.Count()

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, ";\n                Total price:\n                ");
                __builder2.OpenElement(23, "strong");
                __builder2.AddMarkupContent(24, "£");
                __builder2.AddContent(25, 
#line 18 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\MyOrders.razor"
                          item.Order.GetFormattedTotalPrice()

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\n            ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "col");
                __builder2.AddMarkupContent(30, "\n                Status: ");
                __builder2.OpenElement(31, "strong");
                __builder2.AddContent(32, 
#line 21 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\MyOrders.razor"
                                 item.StatusText

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "col flex-grow-0");
                __builder2.AddMarkupContent(37, "\n                ");
                __builder2.OpenElement(38, "a");
                __builder2.AddAttribute(39, "href", "myorders/" + (
#line 24 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\MyOrders.razor"
                                   item.Order.OrderId

#line default
#line hidden
                ));
                __builder2.AddAttribute(40, "class", "btn btn-success");
                __builder2.AddMarkupContent(41, "\n                    Track &gt;\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\n        ");
            }
            );
            __builder.AddMarkupContent(44, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 32 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\MyOrders.razor"
       
    async Task<List<OrderWithStatus>> LoadOrders()
    {
        return await HttpClient.GetJsonAsync<List<OrderWithStatus>>("orders");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
namespace __Blazor.BlazingPizza.Client.Pages.MyOrders
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTemplatedList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<TItem>>> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg4)
        {
        __builder.OpenComponent<global::BlazingComponents.TemplatedList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Loader", __arg0);
        __builder.AddAttribute(__seq1, "ListGroupClass", __arg1);
        __builder.AddAttribute(__seq2, "Loading", __arg2);
        __builder.AddAttribute(__seq3, "Empty", __arg3);
        __builder.AddAttribute(__seq4, "Item", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
