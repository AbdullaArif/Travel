using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig3_comment_syntax : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestDB",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "CommandUser",
                table: "Comments",
                newName: "CommentUser");

            migrationBuilder.RenameColumn(
                name: "CommandState",
                table: "Comments",
                newName: "CommentState");

            migrationBuilder.RenameColumn(
                name: "CommandDate",
                table: "Comments",
                newName: "CommentDate");

            migrationBuilder.RenameColumn(
                name: "CommandContent",
                table: "Comments",
                newName: "CommentContent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentUser",
                table: "Comments",
                newName: "CommandUser");

            migrationBuilder.RenameColumn(
                name: "CommentState",
                table: "Comments",
                newName: "CommandState");

            migrationBuilder.RenameColumn(
                name: "CommentDate",
                table: "Comments",
                newName: "CommandDate");

            migrationBuilder.RenameColumn(
                name: "CommentContent",
                table: "Comments",
                newName: "CommandContent");

            migrationBuilder.AddColumn<byte>(
                name: "TestDB",
                table: "Comments",
                type: "tinyint",
                nullable: true);
        }
    }
}
