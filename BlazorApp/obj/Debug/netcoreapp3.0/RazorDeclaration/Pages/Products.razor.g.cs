#pragma checksum "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e49276ba4c981d6ec64b7d2d926ba5f4321aceb"
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
#line 4 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
using BlazorApp.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private List<Product> products;

    private bool isAddVisible = false;

    private bool isEditVisible = false;

    private Product currentProduct;
    private int i = 1;

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            Console.WriteLine($"{user.Identity.Name} is authenticated.");
        }
        else
        {
            Console.WriteLine("The user is NOT authenticated.");
        }

        var result = await ProductsService.GetProductsAsync("");

        products = result == null ? new List<Product>() : result.ToList();


    }


    private void OnAddClick()
    {
        isAddVisible = true;
        currentProduct = new Product();
    }
    private void OnAddClose(MouseEventArgs e)
    {
        isAddVisible = false;
        currentProduct = null;
    }
    private async Task OnAddSave(MouseEventArgs e)
    {
        await ProductsService.AddProductAsync(currentProduct);
        products.Add(currentProduct);
        OnAddClose(e);

    }
    private void OnEditClick(Product product)
    {
        isEditVisible = true;
        currentProduct = product;
    }
    private void OnEditClose(MouseEventArgs e)
    {
        isEditVisible = false;
        currentProduct = null;
    }
    private async Task OnEditSave(MouseEventArgs e)
    {
        await ProductsService.UpdateProductAsync(currentProduct);
        //products.Add(currentProduct);
        OnEditClose(e);

    }
    private async Task OnDelete(Product product)
    {
        await ProductsService.DeleteProductAsync(product.ProductId);
        products.Remove(product);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductsService { get; set; }
    }
}
#pragma warning restore 1591
