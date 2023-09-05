using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    public partial class update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdProducer",
                table: "producers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdActor",
                table: "actors",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "producers",
                newName: "IdProducer");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "actors",
                newName: "IdActor");
        }
    }
}
