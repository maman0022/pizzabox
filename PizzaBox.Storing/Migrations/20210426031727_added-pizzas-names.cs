using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class addedpizzasnames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Name",
                value: "Custom Pizza");

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "Meat Pizza");

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "Veggie Pizza");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Pizzas",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: null);
        }
    }
}
