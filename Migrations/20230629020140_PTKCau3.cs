using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaithiPTK1062.Migrations
{
    /// <inheritdoc />
    public partial class PTKCau3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PTKCau3",
                columns: table => new
                {
                    hovaten = table.Column<string>(type: "TEXT", nullable: false),
                    diachi = table.Column<string>(type: "TEXT", nullable: false),
                    sodienthoai = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PTKCau3", x => x.hovaten);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PTKCau3");
        }
    }
}
