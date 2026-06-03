using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KodeFlow.Migrations
{
    /// <inheritdoc />
    public partial class PopularContatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_Contatos",
                columns: new[] { "id_Contato", "nr_Telefone", "nr_Celular", "ds_Email" },
                values: new object[]
                {
                    1,
                    "(27) 3333-1458",
                    "(27) 99812-4567",
                    "joao.silva@gmail.com"
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_Contatos",
                keyColumn: "id_Contato",
                keyValue: 1);
        }
    }
}
