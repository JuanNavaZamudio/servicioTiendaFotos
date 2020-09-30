using Microsoft.EntityFrameworkCore.Migrations;

namespace service.Migrations
{
    public partial class changeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "Posts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string))
                .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
