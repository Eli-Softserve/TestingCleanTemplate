using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Persistence.Migrations
{
    public partial class SampleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "tblStudents",
                schema: "dbo",
                columns: table => new
                {
                    iStudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strStudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strStudentSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    iGrade = table.Column<int>(type: "int", nullable: false),
                    dtAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dtEdited = table.Column<DateTime>(type: "datetime2", nullable: false),
                    strAddedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    strEdited = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    bIsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStudents", x => x.iStudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblStudents",
                schema: "dbo");
        }
    }
}
