using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LucenaSolutions.Intern.APICadastro.Web.Migrations
{
    public partial class populandoCLiente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Cliente(Nome,CPF,EnderecoId,DataNascimento,DataCadastro) values ('Douglas','000.000.000-01',1,'2000-01-01',now())");
            migrationBuilder.Sql("Insert into Cliente(Nome,CPF,EnderecoId,DataNascimento,DataCadastro) values ('Miguel','000.000.000-02',2,'2001-01-01',now())");
            migrationBuilder.Sql("Insert into Cliente(Nome,CPF,EnderecoId,DataNascimento,DataCadastro) values ('Alex','000.000.000-03',3,'2002-01-01',now())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Cliente");
        }
    }
}
