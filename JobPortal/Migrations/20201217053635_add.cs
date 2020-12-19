using Microsoft.EntityFrameworkCore.Migrations;

namespace JobPortal.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "city",
                table: "Candidates",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Candidates",
                newName: "FileName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                table: "Candidates",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "FileName",
                table: "Candidates",
                newName: "Image");
        }
    }
}
