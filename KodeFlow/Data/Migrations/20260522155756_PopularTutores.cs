using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KodeFlow.Migrations
{
    /// <inheritdoc />
    public partial class PopularTutores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
              table: "tbl_Tutores",
              columns: new[] { "id_Tutor", "ds_Nome", "ds_CPF", "id_Contato", "id_Endereco" },
              values: new object[]
              {
                    1,
                    "João Silva",
                    "123.456.789-00",
                    1,
                    1
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "tbl_Tutores",
               keyColumn: "id_Tutor",
               keyValue: 1);
        }
    }
}
