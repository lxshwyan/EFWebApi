using Microsoft.EntityFrameworkCore.Migrations;

namespace Msg.Infrastucture.Migrations
{
    public partial class qianzhu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfo2",
                table: "UserInfo2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo");

            migrationBuilder.RenameTable(
                name: "UserInfo2",
                newName: "SF_UserInfo2");

            migrationBuilder.RenameTable(
                name: "UserInfo",
                newName: "SF_UserInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SF_UserInfo2",
                table: "SF_UserInfo2",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SF_UserInfo",
                table: "SF_UserInfo",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SF_UserInfo2",
                table: "SF_UserInfo2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SF_UserInfo",
                table: "SF_UserInfo");

            migrationBuilder.RenameTable(
                name: "SF_UserInfo2",
                newName: "UserInfo2");

            migrationBuilder.RenameTable(
                name: "SF_UserInfo",
                newName: "UserInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfo2",
                table: "UserInfo2",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserInfo",
                table: "UserInfo",
                column: "Id");
        }
    }
}
