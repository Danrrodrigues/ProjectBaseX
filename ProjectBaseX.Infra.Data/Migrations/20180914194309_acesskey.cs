using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectBaseX.Infra.Data.Migrations
{
    public partial class acesskey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccessKey",
                table: "User",
                type: "varchar(32)",
                maxLength: 32,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessKey",
                table: "User");
        }
    }
}
