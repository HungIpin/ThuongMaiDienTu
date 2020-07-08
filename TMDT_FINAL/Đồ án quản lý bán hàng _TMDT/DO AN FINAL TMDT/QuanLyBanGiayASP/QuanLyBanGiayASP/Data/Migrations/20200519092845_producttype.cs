using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanLyBanGiayASP.Data.Migrations
{
    public partial class producttype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeProductId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeProductId",
                table: "Products",
                column: "TypeProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_TypeProducts_TypeProductId",
                table: "Products",
                column: "TypeProductId",
                principalTable: "TypeProducts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_TypeProducts_TypeProductId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_TypeProductId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TypeProductId",
                table: "Products");
        }
    }
}
