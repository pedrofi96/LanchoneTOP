using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchoneTOP.Migrations
{
    public partial class Lanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,EmEstoque,CategoriaId)" +
                "VALUES('Hamburguer Padrão','Hamburguer simples com todos os igredientes frescos', 'Hamburguer simples queijo cheddar, 150g de carne tomate cebola e picles pão de hamburguer',25.90,'https://img.freepik.com/fotos-gratis/hamburguer-saboroso-isolado-no-fundo-branco-fastfood-de-hamburguer-fresco-com-carne-e-queijo_90220-1063.jpg?w=826&t=st=1689681122~exp=1689681722~hmac=534eca9d9683098b568ffaaec215916bd21bba3d5e3f412990aa9add0b829769','https://img.freepik.com/fotos-gratis/hamburguer-saboroso-isolado-no-fundo-branco-fastfood-de-hamburguer-fresco-com-carne-e-queijo_90220-1063.jpg?w=826&t=st=1689681122~exp=1689681722~hmac=534eca9d9683098b568ffaaec215916bd21bba3d5e3f412990aa9add0b829769',1,1)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,EmEstoque,CategoriaId)" +
                "VALUES('Hamburguer TOP','Hamburguer TOP com todos os igredientes frescos', 'HamburguerTOP com queijo cheddar, 180g de carne tomate cebola caramelizada e picles pão de hamburguer',30.90,'https://img.freepik.com/fotos-gratis/hamburguer-saboroso-isolado-no-fundo-branco-fastfood-de-hamburguer-fresco-com-carne-e-queijo_90220-1063.jpg?w=826&t=st=1689681122~exp=1689681722~hmac=534eca9d9683098b568ffaaec215916bd21bba3d5e3f412990aa9add0b829769','https://img.freepik.com/fotos-gratis/hamburguer-saboroso-isolado-no-fundo-branco-fastfood-de-hamburguer-fresco-com-carne-e-queijo_90220-1063.jpg?w=826&t=st=1689681122~exp=1689681722~hmac=534eca9d9683098b568ffaaec215916bd21bba3d5e3f412990aa9add0b829769',1,1)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,EmEstoque,CategoriaId)" +
                "VALUES('Hamburguer PlaceHolder','Hamburguer simples com todos os igredientes frescos', 'Hamburguer simples queijo cheddar, 150g de carne tomate cebola e picles pão de hamburguer',25.90,'https://img.freepik.com/fotos-gratis/hamburguer-saboroso-isolado-no-fundo-branco-fastfood-de-hamburguer-fresco-com-carne-e-queijo_90220-1063.jpg?w=826&t=st=1689681122~exp=1689681722~hmac=534eca9d9683098b568ffaaec215916bd21bba3d5e3f412990aa9add0b829769','https://img.freepik.com/fotos-gratis/hamburguer-saboroso-isolado-no-fundo-branco-fastfood-de-hamburguer-fresco-com-carne-e-queijo_90220-1063.jpg?w=826&t=st=1689681122~exp=1689681722~hmac=534eca9d9683098b568ffaaec215916bd21bba3d5e3f412990aa9add0b829769',1,1)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,EmEstoque,CategoriaId)" +
                "VALUES('Hamburguer PlaceHolder','Hamburguer simples com todos os igredientes frescos', 'Hamburguer simples queijo cheddar, 150g de carne tomate cebola e picles pão de hamburguer',25.90,'https://img.freepik.com/fotos-gratis/hamburguer-saboroso-isolado-no-fundo-branco-fastfood-de-hamburguer-fresco-com-carne-e-queijo_90220-1063.jpg?w=826&t=st=1689681122~exp=1689681722~hmac=534eca9d9683098b568ffaaec215916bd21bba3d5e3f412990aa9add0b829769','https://img.freepik.com/fotos-gratis/hamburguer-saboroso-isolado-no-fundo-branco-fastfood-de-hamburguer-fresco-com-carne-e-queijo_90220-1063.jpg?w=826&t=st=1689681122~exp=1689681722~hmac=534eca9d9683098b568ffaaec215916bd21bba3d5e3f412990aa9add0b829769',1,2)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,EmEstoque,CategoriaId)" +
                "VALUES('Suco','SucoPLACEHOLDER', 'Hamburguer simples queijo cheddar, 150g de carne tomate cebola e picles pão de hamburguer',11.90,'https://img.freepik.com/fotos-gratis/delicioso-copo-de-suco-de-laranja_144627-16581.jpg?w=740&t=st=1689681551~exp=1689682151~hmac=a1c22ce161f171e3e3feaf7e071e88fcec73cac6134d5cc46cdab99e0cffc567','https://img.freepik.com/fotos-gratis/delicioso-copo-de-suco-de-laranja_144627-16581.jpg?w=740&t=st=1689681551~exp=1689682151~hmac=a1c22ce161f171e3e3feaf7e071e88fcec73cac6134d5cc46cdab99e0cffc567',1,3)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,EmEstoque,CategoriaId)" +
                "VALUES('Suco','SucoPLACEHOLDER', 'Hamburguer simples queijo cheddar, 150g de carne tomate cebola e picles pão de hamburguer',11.90,'https://img.freepik.com/fotos-gratis/delicioso-copo-de-suco-de-laranja_144627-16581.jpg?w=740&t=st=1689681551~exp=1689682151~hmac=a1c22ce161f171e3e3feaf7e071e88fcec73cac6134d5cc46cdab99e0cffc567','https://img.freepik.com/fotos-gratis/delicioso-copo-de-suco-de-laranja_144627-16581.jpg?w=740&t=st=1689681551~exp=1689682151~hmac=a1c22ce161f171e3e3feaf7e071e88fcec73cac6134d5cc46cdab99e0cffc567',1,3)");
            migrationBuilder.Sql("INSERT INTO Lanches(Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,EmEstoque,CategoriaId)" +
                "VALUES('Suco','SucoPLACEHOLDER', 'Hamburguer simples queijo cheddar, 150g de carne tomate cebola e picles pão de hamburguer',11.90,'https://img.freepik.com/fotos-gratis/delicioso-copo-de-suco-de-laranja_144627-16581.jpg?w=740&t=st=1689681551~exp=1689682151~hmac=a1c22ce161f171e3e3feaf7e071e88fcec73cac6134d5cc46cdab99e0cffc567','https://img.freepik.com/fotos-gratis/delicioso-copo-de-suco-de-laranja_144627-16581.jpg?w=740&t=st=1689681551~exp=1689682151~hmac=a1c22ce161f171e3e3feaf7e071e88fcec73cac6134d5cc46cdab99e0cffc567',1,4)");



        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
