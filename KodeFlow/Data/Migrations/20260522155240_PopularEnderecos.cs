using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KodeFlow.Migrations
{
    /// <inheritdoc />
    public partial class PopularEnderecos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "tbl_Enderecos",
               columns: new[] { "id_Endereco", "ds_Rua", "ds_Numero", "ds_Complemento", "ds_Bairro", "ds_Cidade", "ds_Estado", "ds_Cep" },
               values: new object[]
               {
                    1,
                    "Rua Exemplo",
                    "123",
                    "Apto 101",
                    "Centro",
                    "São Paulo",
                    "SP",
                    "01000-000"
               });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Enderecos",
                keyColumn: "id_Endereco",
                keyValue: 1);
        }
    }
}
