#pragma checksum "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a815b9b095b8d3f238a81864c3d2a2f0792aaa94"
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
#line 2 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
using BlazorApp.Services.Abstract;

#line default
#line hidden
#nullable disable
    public class OrderProducts : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "tabindex", "-1");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog modal-dialog-scrollable");
            __builder.AddAttribute(7, "role", "document");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-content");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "modal-header");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.AddMarkupContent(15, "<h5 class=\"modal-title\">Products</h5>\r\n                ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "close");
            __builder.AddAttribute(19, "data-dismiss", "modal");
            __builder.AddAttribute(20, "aria-label", "Close");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                                                                                                      OnClose

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.AddMarkupContent(23, "<span aria-hidden=\"true\">&times;</span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "modal-body");
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 16 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                 if (products == null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "                    ");
            __builder.AddMarkupContent(30, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 19 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "                    ");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table");
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.AddMarkupContent(35, @"<thead>
                            <tr>
                                <th></th>
                                <th>Name</th>
                                <th>Unit Price</th>
                                <th>Description</th>
                            </tr>
                        </thead>
                        ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 32 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                             foreach (var product in products)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                                ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\r\n                                    ");
            __builder.OpenElement(41, "td");
            __builder.AddMarkupContent(42, "\r\n                                        ");
            __builder.OpenElement(43, "button");
            __builder.AddAttribute(44, "class", "btn btn-primary");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                                                                                    e => OnAddClick(product)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(46, "+");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 38 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                                         product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                    ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 39 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                                         product.UnitPrice.ToString("F2")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                    ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 40 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                                         product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 42 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 45 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-footer");
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "button");
            __builder.AddAttribute(68, "type", "button");
            __builder.AddAttribute(69, "class", "btn btn-secondary");
            __builder.AddAttribute(70, "data-dismiss", "modal");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
                                                                                               OnClose

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, "Ok");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Projects\Test\SampleOrders\BlazorApp\Pages\OrderProducts.razor"
       
    private IEnumerable<Product> products;

    [Parameter]
    public Func<Product, Task> AddProduct { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> OnClose { get; set; }

    protected override async Task OnInitializedAsync()
    {
        products = await ProductsService.GetProductsAsync("");

    }
    private void OnAddClick(Product product)
    {
        if (AddProduct != null)
        {
            AddProduct(product);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductsService { get; set; }
    }
}
#pragma warning restore 1591
