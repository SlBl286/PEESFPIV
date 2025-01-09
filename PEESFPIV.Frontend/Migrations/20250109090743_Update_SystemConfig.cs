using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PEESFPIV.Frontend.Migrations
{
    /// <inheritdoc />
    public partial class Update_SystemConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Value",
                table: "SystemConfig",
                newName: "VnValue");

            migrationBuilder.AddColumn<string>(
                name: "EnValue",
                table: "SystemConfig",
                type: "nvarchar(max)",
                maxLength: 2147483645,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnValue",
                table: "SystemConfig");

            migrationBuilder.RenameColumn(
                name: "VnValue",
                table: "SystemConfig",
                newName: "Value");
        }
    }
}
