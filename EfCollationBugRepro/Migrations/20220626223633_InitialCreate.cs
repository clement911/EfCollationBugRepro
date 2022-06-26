using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCollationBugRepro.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyEntity",
                columns: table => new
                {
                    KeyCol1 = table.Column<string>(type: "nvarchar(450)", nullable: false, collation: "Latin1_General_100_BIN2"),
                    KeyCol2 = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyEntity", x => new { x.KeyCol1, x.KeyCol2 });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyEntity");
        }
    }
}
