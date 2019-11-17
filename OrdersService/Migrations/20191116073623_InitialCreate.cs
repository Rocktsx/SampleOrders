using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrdersService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orderItems",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    OrderId = table.Column<string>(nullable: false),
                    ProductId = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(20,7)", nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orderItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(20,7)", nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orderItems");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
