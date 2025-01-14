using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PEESFPIV.Frontend.Migrations
{
    /// <inheritdoc />
    public partial class Add_ResearchStudy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResearchStudy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VnTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EnTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    VnDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483645, nullable: true),
                    EnDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 2147483645, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchStudy", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResearchStudy");
        }
    }
}
