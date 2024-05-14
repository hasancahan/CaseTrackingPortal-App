using Microsoft.EntityFrameworkCore.Migrations;

namespace DavaSurecTakip.DataAccess.Migrations
{
    public partial class FullDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "caseDtos");

            migrationBuilder.AddColumn<string>(
                name: "CaseFileStageDto",
                table: "cases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CaseResultDto",
                table: "cases",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CaseSubjectDto",
                table: "cases",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaseFileStageDto",
                table: "cases");

            migrationBuilder.DropColumn(
                name: "CaseResultDto",
                table: "cases");

            migrationBuilder.DropColumn(
                name: "CaseSubjectDto",
                table: "cases");

            migrationBuilder.CreateTable(
                name: "caseDtos",
                columns: table => new
                {
                    IdDto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseResultDto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaseSubjectDto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileStageDto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceDto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caseDtos", x => x.IdDto);
                });
        }
    }
}
