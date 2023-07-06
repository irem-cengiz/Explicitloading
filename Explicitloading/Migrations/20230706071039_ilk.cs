using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Explicitloading.Migrations
{
    public partial class ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Markalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modeller",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MarkaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeller", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modeller_Markalar_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Markalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Markalar",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Peugeot" },
                    { 2, "Mercedes" },
                    { 3, "Audi" },
                    { 4, "Hyundai" }
                });

            migrationBuilder.InsertData(
                table: "Modeller",
                columns: new[] { "Id", "Ad", "MarkaId" },
                values: new object[,]
                {
                    { 1, "206", 1 },
                    { 2, "307", 1 },
                    { 3, "407", 1 },
                    { 4, "AMG One", 2 },
                    { 5, "CLS", 2 },
                    { 6, "EQC", 2 },
                    { 7, "A1", 3 },
                    { 8, "A3", 3 },
                    { 9, "A4", 3 },
                    { 10, "TT", 3 },
                    { 11, "Accent Era", 4 },
                    { 12, "i10", 4 },
                    { 13, "i20", 4 },
                    { 14, "i30", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modeller_MarkaId",
                table: "Modeller",
                column: "MarkaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modeller");

            migrationBuilder.DropTable(
                name: "Markalar");
        }
    }
}
