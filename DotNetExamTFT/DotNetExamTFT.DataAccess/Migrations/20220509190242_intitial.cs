using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetExamTFT.DataAccess.Migrations
{
    public partial class intitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Traits",
                columns: table => new
                {
                    TraitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TraitEffect = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traits", x => x.TraitId);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Mana = table.Column<int>(type: "int", nullable: false),
                    UnitImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitTrait",
                columns: table => new
                {
                    UnitsId = table.Column<int>(type: "int", nullable: false),
                    TraitsTraitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitTrait", x => new { x.UnitsId, x.TraitsTraitId });
                    table.ForeignKey(
                        name: "FK_UnitTrait_Traits_TraitsTraitId",
                        column: x => x.TraitsTraitId,
                        principalTable: "Traits",
                        principalColumn: "TraitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitTrait_Units_UnitsId",
                        column: x => x.UnitsId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "TraitId", "TraitEffect", "TraitName" },
                values: new object[,]
                {
                    { 1, "Certain allies are cloaked in shadows, gaining 50 Armor, 50 Magic Resist and 20% Omnivamp (healing for a percentage of all damage dealt.)", "Syndicate" },
                    { 2, "Bodyguards have increased Armor. Shortly after combat begins, Bodyguards gain a shield and taunt adjacent enemies, forcing them to attack the Bodyguard.", "Bodyguard" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Cost", "Mana", "Name", "UnitImage" },
                values: new object[,]
                {
                    { 1, 2, 0, "Blitzcrank", null },
                    { 2, 4, 0, "Braum", null },
                    { 3, 1, 0, "Darius", null },
                    { 4, 5, 0, "Galio", null },
                    { 5, 3, 0, "Leona", null },
                    { 6, 1, 0, "Poppy", null },
                    { 7, 4, 0, "Ahri", null },
                    { 8, 2, 0, "Ashe", null },
                    { 9, 3, 0, "Morgana", null },
                    { 10, 2, 0, "Zyra", null }
                });

            migrationBuilder.InsertData(
                table: "UnitTrait",
                columns: new[] { "TraitsTraitId", "UnitsId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitTrait_TraitsTraitId",
                table: "UnitTrait",
                column: "TraitsTraitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitTrait");

            migrationBuilder.DropTable(
                name: "Traits");

            migrationBuilder.DropTable(
                name: "Units");
        }
    }
}
