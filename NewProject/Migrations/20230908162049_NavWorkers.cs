using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProject.Migrations
{
    /// <inheritdoc />
    public partial class NavWorkers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SecDepId",
                table: "Managers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Managers_SecDepId",
                table: "Managers",
                column: "SecDepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_Departments_SecDepId",
                table: "Managers",
                column: "SecDepId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managers_Departments_SecDepId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Managers_SecDepId",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "SecDepId",
                table: "Managers");
        }
    }
}
