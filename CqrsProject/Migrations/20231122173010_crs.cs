using Microsoft.EntityFrameworkCore.Migrations;

namespace CqrsProject.Migrations
{
    public partial class crs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personals",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personals", x => x.PersonelId);
                });

            migrationBuilder.InsertData(
                table: "Personals",
                columns: new[] { "PersonelId", "Age", "LastName", "Name", "Salary" },
                values: new object[] { 1, 38, "Sarı", "Sinan", 50000m });

            migrationBuilder.InsertData(
                table: "Personals",
                columns: new[] { "PersonelId", "Age", "LastName", "Name", "Salary" },
                values: new object[] { 2, 37, "Kaya", "Suzan", 60000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personals");
        }
    }
}
