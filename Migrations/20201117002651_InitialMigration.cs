using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaProblems.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    dough_type = table.Column<string>(maxLength: 250, nullable: false),
                    isCalzone = table.Column<bool>(maxLength: 250, nullable: false),
                    ingredients = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
