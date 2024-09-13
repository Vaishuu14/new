using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentManagment.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrollments_Courses_CourseID",
                table: "Entrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrollments_Students_StudentID",
                table: "Entrollments");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Entrollments",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "CourseID",
                table: "Entrollments",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "EntrollmentDate",
                table: "Entrollments",
                newName: "EnrollmentDate");

            migrationBuilder.RenameIndex(
                name: "IX_Entrollments_StudentID",
                table: "Entrollments",
                newName: "IX_Entrollments_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Entrollments_CourseID",
                table: "Entrollments",
                newName: "IX_Entrollments_CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrollments_Courses_CourseId",
                table: "Entrollments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrollments_Students_StudentId",
                table: "Entrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entrollments_Courses_CourseId",
                table: "Entrollments");

            migrationBuilder.DropForeignKey(
                name: "FK_Entrollments_Students_StudentId",
                table: "Entrollments");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Entrollments",
                newName: "StudentID");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Entrollments",
                newName: "CourseID");

            migrationBuilder.RenameColumn(
                name: "EnrollmentDate",
                table: "Entrollments",
                newName: "EntrollmentDate");

            migrationBuilder.RenameIndex(
                name: "IX_Entrollments_StudentId",
                table: "Entrollments",
                newName: "IX_Entrollments_StudentID");

            migrationBuilder.RenameIndex(
                name: "IX_Entrollments_CourseId",
                table: "Entrollments",
                newName: "IX_Entrollments_CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Entrollments_Courses_CourseID",
                table: "Entrollments",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entrollments_Students_StudentID",
                table: "Entrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
