using Microsoft.EntityFrameworkCore.Migrations;

namespace Property_Management_API.Migrations
{
    public partial class Property_obj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Property");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Property",
                newName: "Property_Type");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Property",
                newName: "Facilities");

            migrationBuilder.RenameColumn(
                name: "Customer_Name",
                table: "Property",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "CV",
                table: "Property",
                newName: "Price");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Property_Type",
                table: "Property",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Property",
                newName: "CV");

            migrationBuilder.RenameColumn(
                name: "Facilities",
                table: "Property",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "Property",
                newName: "Customer_Name");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Property",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
