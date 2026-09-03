using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MCP_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class muchHaveBeenDone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_useronscooter",
                table: "useronscooter");

            migrationBuilder.DropIndex(
                name: "ix_useronscooter_scooterid",
                table: "useronscooter");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "useronscooter",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "scooter",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "pk_useronscooter",
                table: "useronscooter",
                columns: new[] { "scooterid", "app_userid" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_useronscooter",
                table: "useronscooter");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "useronscooter",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "status",
                table: "scooter",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_useronscooter",
                table: "useronscooter",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "ix_useronscooter_scooterid",
                table: "useronscooter",
                column: "scooterid");
        }
    }
}
