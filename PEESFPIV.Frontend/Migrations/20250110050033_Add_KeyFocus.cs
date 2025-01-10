using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PEESFPIV.Frontend.Migrations
{
    /// <inheritdoc />
    public partial class Add_KeyFocus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyFocus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VnTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EnTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    VnDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483645, nullable: false),
                    EnDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483645, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyFocus", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KeyFocus");
        }
    }
}
