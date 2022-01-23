using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_WPF.Migrations
{
    public partial class nyareupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Subjects_SubjectId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_SubjectId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "ErrandDate",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ErrandDate",
                table: "Subjects");

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_SubjectId",
                table: "Customers",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Subjects_SubjectId",
                table: "Customers",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
