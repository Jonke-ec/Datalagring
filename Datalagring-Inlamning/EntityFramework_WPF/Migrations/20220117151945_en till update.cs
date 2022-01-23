using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_WPF.Migrations
{
    public partial class entillupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Subjects_SubjectErrandId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "ErrandId",
                table: "Subjects",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SubjectErrandId",
                table: "Customers",
                newName: "SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_SubjectErrandId",
                table: "Customers",
                newName: "IX_Customers_SubjectId");

            migrationBuilder.AddColumn<int>(
                name: "ErrandId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Subjects_SubjectId",
                table: "Customers",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Subjects_SubjectId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ErrandId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Subjects",
                newName: "ErrandId");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Customers",
                newName: "SubjectErrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_SubjectId",
                table: "Customers",
                newName: "IX_Customers_SubjectErrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Subjects_SubjectErrandId",
                table: "Customers",
                column: "SubjectErrandId",
                principalTable: "Subjects",
                principalColumn: "ErrandId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
