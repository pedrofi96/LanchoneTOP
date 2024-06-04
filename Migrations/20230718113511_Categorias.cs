using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchoneTOP.Migrations
{
    public partial class Produtos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                "VALUES('Hamburguer','Hamburgueres Deliciosos')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
            "VALUES('naturais','Sandwiches Naturais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
           "VALUES('Sucos','Sucos naturais feitos na hora')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
           "VALUES('Refrigerantes','Refrigerantes Guarana, Coca-Cola, Fanta Uva e Fanta Guarana')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
