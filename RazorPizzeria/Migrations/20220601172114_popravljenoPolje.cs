using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPizzeria.Migrations
{
    public partial class popravljenoPolje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "PizzaOrders",
                newName: "BasePrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BasePrice",
                table: "PizzaOrders",
                newName: "MyProperty");
        }
    }
}
