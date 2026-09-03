using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MCP_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreatedDAO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "useronscooter",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scooterid = table.Column<int>(type: "integer", nullable: false),
                    app_userid = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_useronscooter", x => x.id);
                    table.ForeignKey(
                        name: "fk_useronscooter_app_user_app_userid",
                        column: x => x.app_userid,
                        principalTable: "app_user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_useronscooter_scooter_scooterid",
                        column: x => x.scooterid,
                        principalTable: "scooter",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_useronscooter_app_userid",
                table: "useronscooter",
                column: "app_userid");

            migrationBuilder.CreateIndex(
                name: "ix_useronscooter_scooterid",
                table: "useronscooter",
                column: "scooterid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "useronscooter");
        }
    }
}
