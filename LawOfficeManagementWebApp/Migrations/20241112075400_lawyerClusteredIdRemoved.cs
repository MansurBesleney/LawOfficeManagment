using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LawOfficeManagementWebApp.Migrations
{
    /// <inheritdoc />
    public partial class lawyerClusteredIdRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientLawyer_Lawyer_LawyersId",
                table: "ClientLawyer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lawyer",
                table: "Lawyer");

            migrationBuilder.RenameTable(
                name: "Lawyer",
                newName: "Lawyers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lawyers",
                table: "Lawyers",
                column: "Id")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientLawyer_Lawyers_LawyersId",
                table: "ClientLawyer",
                column: "LawyersId",
                principalTable: "Lawyers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClientLawyer_Lawyers_LawyersId",
                table: "ClientLawyer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lawyers",
                table: "Lawyers");

            migrationBuilder.RenameTable(
                name: "Lawyers",
                newName: "Lawyer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lawyer",
                table: "Lawyer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ClientLawyer_Lawyer_LawyersId",
                table: "ClientLawyer",
                column: "LawyersId",
                principalTable: "Lawyer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
