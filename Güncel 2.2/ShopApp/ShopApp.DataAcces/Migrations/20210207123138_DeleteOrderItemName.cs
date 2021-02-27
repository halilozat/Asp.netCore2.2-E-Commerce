using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopApp.DataAcces.Migrations
{
    public partial class DeleteOrderItemName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderItem");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderItem",
                nullable: true);
        }
    }
}
