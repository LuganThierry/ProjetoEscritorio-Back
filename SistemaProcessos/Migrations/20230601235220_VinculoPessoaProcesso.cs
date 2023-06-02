using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaProcessos.Migrations
{
    public partial class VinculoPessoaProcesso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Processos_Advogado_id",
                table: "Processos",
                column: "Advogado_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Processos_Pessoas_Advogado_id",
                table: "Processos",
                column: "Advogado_id",
                principalTable: "Pessoas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processos_Pessoas_Advogado_id",
                table: "Processos");

            migrationBuilder.DropIndex(
                name: "IX_Processos_Advogado_id",
                table: "Processos");
        }
    }
}
