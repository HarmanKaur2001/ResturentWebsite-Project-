using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ResturentWebsite.Data.Migrations
{
    public partial class CreateInitials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreakfastDishes = table.Column<string>(type: "varchar(20)", nullable: false),
                    LunchDishes = table.Column<string>(type: "varchar(20)", nullable: false),
                    DinnerDishes = table.Column<string>(type: "varchar(20)", nullable: false),
                    Snacks = table.Column<string>(type: "varchar(20)", nullable: false),
                    EspacialDishes = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.DishID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    WineTasting = table.Column<string>(type: "varchar(20)", nullable: false),
                    CocktailWorkshope = table.Column<string>(type: "varchar(20)", nullable: false),
                    Brunch = table.Column<string>(type: "varchar(20)", nullable: false),
                    Location = table.Column<string>(type: "varchar(20)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.WineTasting);
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(20)", nullable: false),
                    LastName = table.Column<string>(type: "varchar(20)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "varchar(20)", nullable: false),
                    City = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBack", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Starters = table.Column<string>(type: "varchar(20)", nullable: false),
                    MainCourse = table.Column<string>(type: "varchar(20)", nullable: false),
                    Drinks = table.Column<int>(type: "int", nullable: false),
                    Sides = table.Column<string>(type: "varchar(20)", nullable: false),
                    Desert = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderID);
                });

            migrationBuilder.CreateTable(
                name: "OurTeam",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasterChef = table.Column<int>(type: "int", nullable: false),
                    SousChef = table.Column<int>(type: "int", nullable: false),
                    CrewMembers = table.Column<int>(type: "int", nullable: false),
                    Bartender = table.Column<int>(type: "int", nullable: false),
                    Cashier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurTeam", x => x.TeamID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OurTeam");
        }
    }
}
