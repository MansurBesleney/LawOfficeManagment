using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LawOfficeManagmentWebApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigraiton : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientTcNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClientSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClientGSM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
