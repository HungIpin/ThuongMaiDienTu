using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyBanGiayASP.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypeProducts_TypeProductId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "TypeProductId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerPersonId",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerPersonId",
                table: "Orders",
                column: "CustomerPersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerPersonId",
                table: "Orders",
                column: "CustomerPersonId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypeProducts_TypeProductId",
                table: "Products",
                column: "TypeProductId",
                principalTable: "TypeProducts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerPersonId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypeProducts_TypeProductId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerPersonId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerPersonId",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "TypeProductId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypeProducts_TypeProductId",
                table: "Products",
                column: "TypeProductId",
                principalTable: "TypeProducts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
