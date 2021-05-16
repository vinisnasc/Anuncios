using Microsoft.EntityFrameworkCore.Migrations;

namespace Anuncios.Data.Migrations
{
    public partial class CalculadoraMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "InvestTotal",
                table: "Anuncio",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MaxCliques",
                table: "Anuncio",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MaxComp",
                table: "Anuncio",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MaxVisualizacao",
                table: "Anuncio",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvestTotal",
                table: "Anuncio");

            migrationBuilder.DropColumn(
                name: "MaxCliques",
                table: "Anuncio");

            migrationBuilder.DropColumn(
                name: "MaxComp",
                table: "Anuncio");

            migrationBuilder.DropColumn(
                name: "MaxVisualizacao",
                table: "Anuncio");
        }
    }
}
