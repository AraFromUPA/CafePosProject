using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CafeApiProj.Migrations
{
    /// <inheritdoc />
    public partial class _1111 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Orders_OrdersId",
                table: "OrderProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderProducts_OrdersId",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "OrdersId",
                table: "OrderProducts");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderProducts");

            migrationBuilder.AddColumn<Guid>(
                name: "OrdersId",
                table: "OrderProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrdersId",
                table: "OrderProducts",
                column: "OrdersId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Orders_OrdersId",
                table: "OrderProducts",
                column: "OrdersId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
