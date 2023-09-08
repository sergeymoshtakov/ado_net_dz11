using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProject.Migrations
{
    /// <inheritdoc />
    public partial class NavChef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Managers_IdChief",
                table: "Managers",
                column: "IdChief");

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Managers_IdChief",
                table: "Managers",
                column: "IdChief",
                principalTable: "Managers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Managers_IdChief",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Managers_IdChief",
                table: "Managers");
        }
    }
}
