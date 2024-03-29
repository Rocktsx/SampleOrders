#pragma checksum "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Orders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e49a4a863cb4f12bd43f6ee4210cd21f82667fc1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Test\SampleOrders\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Test\SampleOrders\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Test\SampleOrders\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Test\SampleOrders\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Test\SampleOrders\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Test\SampleOrders\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Test\SampleOrders\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\Test\SampleOrders\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Test\SampleOrders\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Orders.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Orders.razor"
using BlazorApp.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Orders.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orders")]
    public class Orders : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Orders.razor"
       
    private List<Order> orders;

    private bool isAddVisible = false;

    private bool isEditVisible = false;

    private Order currentOrder;

    protected override async Task OnInitializedAsync()
    {
        var result = await OrdersService.GetOrdersAsync();
        orders = result.ToList();

    }


    private void OnAddClick()
    {
        isAddVisible = true;
        currentOrder = new Order() { OrderDate = DateTime.Now };
    }
    private void OnAddClose(MouseEventArgs e)
    {
        isAddVisible = false;
        currentOrder = null;
    }
    private async Task OnAddSave(MouseEventArgs e)
    {
        currentOrder = await OrdersService.AddAsync(currentOrder);
        orders.Add(currentOrder);
        OnAddClose(e);

    }
    private void OnEditClick(Order order)
    {
        isEditVisible = true;
        currentOrder = order;
    }
    private void OnEditClose(MouseEventArgs e)
    {
        isEditVisible = false;
        currentOrder = null;
    }
    private async Task OnEditSave(MouseEventArgs e)
    {
        await OrdersService.UpdateAsync(currentOrder);
        OnEditClose(e);

    }

    private async Task OnDelete(Order order)
    {
        await OrdersService.DeleteAsync(order.OrderId);
        orders.Remove(order);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IOrderService OrdersService { get; set; }
    }
}
#pragma warning restore 1591
