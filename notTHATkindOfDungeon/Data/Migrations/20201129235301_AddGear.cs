using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace notTHATkindOfDungeon.Data.Migrations
{
    public partial class AddGear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gears",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Attack = table.Column<int>(nullable: true),
                    Defense = table.Column<int>(nullable: true),
                    HealingPower = table.Column<int>(nullable: true),
                    InventoryIncrease = table.Column<int>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: false),
                    ItemName = table.Column<string>(nullable: false),
                    ItemType = table.Column<string>(nullable: false),
                    ScoreRequirement = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gears", x => x.ItemId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gears");
        }
    }
}
