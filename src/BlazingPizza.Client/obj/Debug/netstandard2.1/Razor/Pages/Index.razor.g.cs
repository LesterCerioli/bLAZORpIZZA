#pragma checksum "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee44076fb982db0356fcbae01b76729e7a4843b3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pizza-cards");
            __builder.AddMarkupContent(5, "\n");
#line 9 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
         if (specials != null)
        {
            

#line default
#line hidden
#line 11 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
             foreach (var special in specials)
            {

#line default
#line hidden
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                                () => OrderState.ShowConfigurePizzaDialog(special)

#line default
#line hidden
            ));
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#line 13 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                                                                                                                    special.ImageUrl

#line default
#line hidden
            ) + "\')");
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "pizza-info");
            __builder.AddMarkupContent(13, "\n                        ");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "class", "title");
            __builder.AddContent(16, 
#line 15 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                                             special.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                        ");
            __builder.AddContent(18, 
#line 16 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                         special.Description

#line default
#line hidden
            );
            __builder.AddMarkupContent(19, "\n                        ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "class", "price");
            __builder.AddContent(22, 
#line 17 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                                             special.GetFormattedBasePrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n");
#line 20 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
            }

#line default
#line hidden
#line 20 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(26, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n\n");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "sidebar");
            __builder.AddMarkupContent(31, "\n");
#line 26 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
     if (Order.Pizzas.Any())
    {

#line default
#line hidden
            __builder.AddContent(32, "        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "order-contents");
            __builder.AddMarkupContent(35, "\n            ");
            __builder.AddMarkupContent(36, "<h2>Your order</h2>\n\n");
#line 31 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
             foreach (var configuredPizza in Order.Pizzas)
            {

#line default
#line hidden
            __builder.AddContent(37, "                ");
            __builder.OpenComponent<BlazingPizza.Client.Shared.ConfiguredPizzaItem>(38);
            __builder.AddAttribute(39, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#line 33 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                                            configuredPizza

#line default
#line hidden
            ));
            __builder.AddAttribute(40, "OnRemoved", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 33 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                                                                          () => RemovePizza(configuredPizza)

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\n");
#line 34 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
            }

#line default
#line hidden
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n");
#line 36 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(44, "        ");
            __builder.AddMarkupContent(45, "<div class=\"empty-cart\">Choose a pizza<br>to get started</div>\n");
#line 40 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(46, "\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "order-total" + " " + (
#line 42 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                              Order.Pizzas.Any() ? "" : "hidden"

#line default
#line hidden
            ));
            __builder.AddMarkupContent(49, "\n        Total:\n        ");
            __builder.OpenElement(50, "span");
            __builder.AddAttribute(51, "class", "total-price");
            __builder.AddContent(52, 
#line 44 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                                   Order.GetFormattedTotalPrice()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\n        ");
            __builder.OpenElement(54, "a");
            __builder.AddAttribute(55, "href", "checkout");
            __builder.AddAttribute(56, "class", "btn btn-warning");
            __builder.AddAttribute(57, "disabled", 
#line 45 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                                                               Order.Pizzas.Count == 0

#line default
#line hidden
            );
            __builder.AddMarkupContent(58, "\n            Order >\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n\n");
            __builder.OpenComponent<BlazingComponents.TemplatedDialog>(62);
            __builder.AddAttribute(63, "Show", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#line 51 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                       OrderState.ShowingConfigureDialog

#line default
#line hidden
            ));
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "\n    ");
                __builder2.OpenComponent<BlazingPizza.Client.Shared.ConfigurePizzaDialog>(66);
                __builder2.AddAttribute(67, "Pizza", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazingPizza.Pizza>(
#line 53 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
               OrderState.ConfiguringPizza

#line default
#line hidden
                ));
                __builder2.AddAttribute(68, "OnCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 54 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                  OrderState.CancelConfigurePizzaDialog

#line default
#line hidden
                )));
                __builder2.AddAttribute(69, "OnConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#line 55 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
                   OrderState.ConfirmConfigurePizzaDialog

#line default
#line hidden
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(70, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#line 58 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Index.razor"
       
    List<PizzaSpecial> specials;
    Order Order => OrderState.Order;

    protected async override Task OnInitializedAsync()
    {
        specials = await HttpClient.GetJsonAsync<List<PizzaSpecial>>("specials");
    }

    async Task RemovePizza(Pizza configuredPizza)
    {
        if (await JS.Confirm($"Remove {configuredPizza.Special.Name} pizza from the order?"))
        {
            OrderState.RemoveConfiguredPizza(configuredPizza);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
