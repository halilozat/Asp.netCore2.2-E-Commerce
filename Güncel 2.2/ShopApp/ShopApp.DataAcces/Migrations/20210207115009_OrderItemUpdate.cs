using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.DataAcces.Migrations
{
    public partial class OrderItemUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderItem",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderItem");
        }
    }
}
