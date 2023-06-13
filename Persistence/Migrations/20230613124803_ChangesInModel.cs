using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_ESTUDANTES.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_Id",
                table: "Courses");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_Id",
                table: "Students",
                column: "Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_Id",
                table: "Students");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_Id",
                table: "Courses",
                column: "Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
