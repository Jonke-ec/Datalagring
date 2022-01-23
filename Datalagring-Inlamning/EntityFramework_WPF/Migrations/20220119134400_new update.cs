using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_WPF.Migrations
{
    public partial class newupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Subjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CustomerId",
                table: "Subjects",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Customers_CustomerId",
                table: "Subjects",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Customers_CustomerId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_CustomerId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Subjects");
        }
    }
}
