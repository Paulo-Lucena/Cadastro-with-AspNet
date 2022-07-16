using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LucenaSolutions.Intern.APICadastro.Web.Migrations
{
    public partial class populando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Endereco(Logradouro,Numero) Values ('Avenida Airton Senna','876')");
            migrationBuilder.Sql("Insert into Endereco(Logradouro,Numero) Values ('Rua São José','1')");
            migrationBuilder.Sql("Insert into Endereco(Logradouro,Numero) Values ('Travessa Abdias','87-b')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Endereco");
        }
    }
}
