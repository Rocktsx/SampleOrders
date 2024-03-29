#pragma checksum "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e49276ba4c981d6ec64b7d2d926ba5f4321aceb"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Products</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-primary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                                              OnAddClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Add New Product");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 17 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.AddMarkupContent(10, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 20 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
}

else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<thead>\r\n            <tr>\r\n                <th>Operation</th>\r\n                <th>Name</th>\r\n                <th>Unit Price</th>\r\n                <th>Description</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(16, "tbody");
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 34 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenComponent<BlazorStrap.BSDropdown>(23);
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.OpenComponent<BlazorStrap.BSDropdownToggle>(26);
                __builder2.AddAttribute(27, "class", "btn btn-primary");
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(29, "Operation");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenComponent<BlazorStrap.BSDropdownMenu>(31);
                __builder2.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(33, "\r\n                                ");
                    __builder3.OpenComponent<BlazorStrap.BSDropdownItem>(34);
                    __builder3.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                                                                        e => OnEditClick(product)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(37, "Change");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n                                ");
                    __builder3.OpenComponent<BlazorStrap.BSDropdownItem>(39);
                    __builder3.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                                                                        e => OnDelete(product)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(42, "Delete");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n                        \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 49 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                         product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 50 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                         product.UnitPrice.ToString("F2")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 51 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                         product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 53 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 56 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(60, "\r\n");
#nullable restore
#line 58 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
 if (isAddVisible)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "    ");
            __builder.OpenComponent<BlazorApp.Pages.EditProduct>(62);
            __builder.AddAttribute(63, "Title", "Add New Product");
            __builder.AddAttribute(64, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                                                  OnAddClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(65, "OnSave", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                                                                      OnAddSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(66, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.Data.Product>(
#nullable restore
#line 60 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                                                                                          currentProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 61 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
 if (isEditVisible)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "    ");
            __builder.OpenComponent<BlazorApp.Pages.EditProduct>(69);
            __builder.AddAttribute(70, "Title", "Edit Product");
            __builder.AddAttribute(71, "OnClose", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                                               OnEditClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(72, "OnSave", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                                                                    OnEditSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(73, "Product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorApp.Data.Product>(
#nullable restore
#line 65 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"
                                                                                         currentProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 66 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\Products.razor"

}

#line default
#line hidden
#nullable disable
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
