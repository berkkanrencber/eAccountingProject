using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eAccountingServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class mg6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaxDepartmant",
                table: "Companies",
                newName: "TaxDepartment");

            migrationBuilder.RenameColumn(
                name: "FullAdress",
                table: "Companies",
                newName: "FullAddress");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaxDepartment",
                table: "Companies",
                newName: "TaxDepartmant");

            migrationBuilder.RenameColumn(
                name: "FullAddress",
                table: "Companies",
                newName: "FullAdress");
        }
    }
}
