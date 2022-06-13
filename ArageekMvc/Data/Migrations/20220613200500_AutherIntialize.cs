using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArageekMvc.Data.Migrations
{
    public partial class AutherIntialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "articals",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "articals",
                newName: "Title");

            migrationBuilder.AddColumn<int>(
                name: "AutherId",
                table: "articals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "articals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Auther",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auther", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_articals_AutherId",
                table: "articals",
                column: "AutherId");

            migrationBuilder.AddForeignKey(
                name: "FK_articals_Auther_AutherId",
                table: "articals",
                column: "AutherId",
                principalTable: "Auther",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_articals_Auther_AutherId",
                table: "articals");

            migrationBuilder.DropTable(
                name: "Auther");

            migrationBuilder.DropIndex(
                name: "IX_articals_AutherId",
                table: "articals");

            migrationBuilder.DropColumn(
                name: "AutherId",
                table: "articals");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "articals");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "articals",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "articals",
                newName: "Name");
        }
    }
}
