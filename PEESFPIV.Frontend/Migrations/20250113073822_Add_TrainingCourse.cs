using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PEESFPIV.Frontend.Migrations
{
    /// <inheritdoc />
    public partial class Add_TrainingCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainingCourse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VnTitle = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    EnTitle = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    VnAddress = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    EnAddress = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    NumOfParticipation = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCourse", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingCourse");
        }
    }
}
