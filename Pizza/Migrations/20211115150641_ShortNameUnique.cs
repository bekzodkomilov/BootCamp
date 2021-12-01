using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizza.Migrations
{
    public partial class ShortNameUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_ShortName",
                table: "Pizzas",
                column: "ShortName",
                unique: true,
                filter: "[ShortName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pizzas_ShortName",
                table: "Pizzas");
        }
    }
}
