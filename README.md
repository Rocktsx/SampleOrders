# SampleOrders
Sample Orders build with Blzaor, Identity Server 4, Grpc.
这个项目包含三个项目：
	BlazorApp ：Blazor UI
	IdentityServer :　IdentityServer 4
	OrdersService : order service api
要运行这个项目：
首先配置 OrdersService 的数据库连接，数据库使用 Sql Server。
然后 运行 OrdersService 、IdentityServer。
最后运行 BlazorApp，IdentityServer 使用测试账号：bob/bob。