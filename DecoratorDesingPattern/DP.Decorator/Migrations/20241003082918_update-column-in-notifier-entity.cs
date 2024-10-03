using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DP.Decorator.Migrations
{
    public partial class updatecolumninnotifierentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotifierContent",
                table: "Notifiers",
                newName: "NotifierSubject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotifierSubject",
                table: "Notifiers",
                newName: "NotifierContent");
        }
    }
}
