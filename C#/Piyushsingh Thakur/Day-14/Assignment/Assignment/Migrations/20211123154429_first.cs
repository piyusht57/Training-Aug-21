using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustId);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturingPlants",
                columns: table => new
                {
                    PlantId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManufacturingPlants", x => x.PlantId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AdId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Pincode = table.Column<int>(nullable: false),
                    CustId = table.Column<int>(nullable: false),
                    CustomersCustId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AdId);
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomersCustId",
                        column: x => x.CustomersCustId,
                        principalTable: "Customers",
                        principalColumn: "CustId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Toys",
                columns: table => new
                {
                    ToyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToyName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    PlantId = table.Column<int>(nullable: false),
                    ManufacturingPlantPlantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toys", x => x.ToyId);
                    table.ForeignKey(
                        name: "FK_Toys_ManufacturingPlants_ManufacturingPlantPlantId",
                        column: x => x.ManufacturingPlantPlantId,
                        principalTable: "ManufacturingPlants",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    Items = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    CustId = table.Column<int>(nullable: false),
                    CustomersCustId = table.Column<int>(nullable: true),
                    AdId = table.Column<int>(nullable: false),
                    AddressesAdId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressesAdId",
                        column: x => x.AddressesAdId,
                        principalTable: "Addresses",
                        principalColumn: "AdId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomersCustId",
                        column: x => x.CustomersCustId,
                        principalTable: "Customers",
                        principalColumn: "CustId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderToys",
                columns: table => new
                {
                    ToyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToysToyId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    OrdersOrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderToys", x => x.ToyId);
                    table.ForeignKey(
                        name: "FK_OrderToys_Orders_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderToys_Toys_ToysToyId",
                        column: x => x.ToysToyId,
                        principalTable: "Toys",
                        principalColumn: "ToyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomersCustId",
                table: "Addresses",
                column: "CustomersCustId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressesAdId",
                table: "Orders",
                column: "AddressesAdId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomersCustId",
                table: "Orders",
                column: "CustomersCustId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToys_OrdersOrderId",
                table: "OrderToys",
                column: "OrdersOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderToys_ToysToyId",
                table: "OrderToys",
                column: "ToysToyId");

            migrationBuilder.CreateIndex(
                name: "IX_Toys_ManufacturingPlantPlantId",
                table: "Toys",
                column: "ManufacturingPlantPlantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderToys");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Toys");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "ManufacturingPlants");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
