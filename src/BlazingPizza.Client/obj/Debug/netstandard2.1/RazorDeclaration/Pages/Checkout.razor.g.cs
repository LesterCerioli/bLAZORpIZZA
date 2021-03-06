#pragma checksum "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1793cf5c383c3d4f955035d72e7a8a34f6e89ce"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 36 "C:\Users\Diretoria2018\Downloads\blazor-workshop-master\blazor-workshop-master\src\BlazingPizza.Client\Pages\Checkout.razor"
       
    bool isSubmitting;
    [CascadingParameter] Task<AuthenticationState> AuthenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateTask;
        if (!authState.User.Identity.IsAuthenticated)
        {
            // The server won't accept orders from unauthenticated users, so avoid
            // an error by making them log in at this point
            await LocalStorage.SetAsync(JSRuntime, "currentorder", OrderState.Order);
            NavigationManager.NavigateTo("user/signin?redirectUri=/checkout", true);
        }

        // Try to recover any temporary saved order
        if (!OrderState.Order.Pizzas.Any())
        {
            var savedOrder = await LocalStorage.GetAsync<Order>(JSRuntime, "currentorder");
            if (savedOrder != null)
            {
                OrderState.ReplaceOrder(savedOrder);
                await LocalStorage.DeleteAsync(JSRuntime, "currentorder");
            }
            else
            {
                // There's nothing check out - go to home
                NavigationManager.NavigateTo("");
            }
        }

        // In the background, ask if they want to be notified about order updates
        _ = RequestNotificationSubscriptionAsync();
    }

    async Task PlaceOrder()
    {
        isSubmitting = true;

        try
        {
            var newOrderId = await HttpClient.PostJsonAsync<int>("orders", OrderState.Order);
            OrderState.ResetOrder();
            NavigationManager.NavigateTo($"myorders/{newOrderId}");
        }
        finally
        {
            isSubmitting = false;
        }
    }

    async Task RequestNotificationSubscriptionAsync()
    {
        var subscription = await JSRuntime.InvokeAsync<NotificationSubscription>("blazorPushNotifications.requestSubscription");
        if (subscription != null)
        {
            await HttpClient.PutJsonAsync<object>("notifications/subscribe", subscription);
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
    }
}
#pragma warning restore 1591
