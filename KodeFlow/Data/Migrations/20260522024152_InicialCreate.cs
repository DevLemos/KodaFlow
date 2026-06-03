using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KodeFlow.Migrations
{
    /// <inheritdoc />
    public partial class InicialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Contatos",
                columns: table => new
                {
                    id_Contato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nr_Telefone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    nr_Celular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ds_Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Contatos", x => x.id_Contato);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Enderecos",
                columns: table => new
                {
                    id_Endereco = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ds_Rua = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ds_Numero = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ds_Complemento = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ds_Bairro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ds_Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ds_Estado = table.Column<string>(type: "char(2)", maxLength: 2, nullable: false),
                    ds_Cep = table.Column<string>(type: "char(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Enderecos", x => x.id_Endereco);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Especialidades",
                columns: table => new
                {
                    id_Especialidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ds_Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ds_Descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Especialidades", x => x.id_Especialidade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Especies",
                columns: table => new
                {
                    id_Especie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ds_Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ds_NomeCientifico = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Especies", x => x.id_Especie);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Veterinarios",
                columns: table => new
                {
                    id_Veterinario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ds_Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    nr_Crmv = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Veterinarios", x => x.id_Veterinario);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Tutores",
                columns: table => new
                {
                    id_Tutor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ds_Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ds_CPF = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    id_Contato = table.Column<int>(type: "int", nullable: false),
                    id_Endereco = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Tutores", x => x.id_Tutor);
                    table.ForeignKey(
                        name: "FK_tbl_Tutores_tbl_Contatos_id_Contato",
                        column: x => x.id_Contato,
                        principalTable: "tbl_Contatos",
                        principalColumn: "id_Contato",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Tutores_tbl_Enderecos_id_Endereco",
                        column: x => x.id_Endereco,
                        principalTable: "tbl_Enderecos",
                        principalColumn: "id_Endereco",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Racas",
                columns: table => new
                {
                    id_Raca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ds_Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    id_Especie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Racas", x => x.id_Raca);
                    table.ForeignKey(
                        name: "FK_tbl_Racas_tbl_Especies_id_Especie",
                        column: x => x.id_Especie,
                        principalTable: "tbl_Especies",
                        principalColumn: "id_Especie",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EspecialidadeVeterinario",
                columns: table => new
                {
                    EspecialidadesEspecialidadeId = table.Column<int>(type: "int", nullable: false),
                    VeterinariosVeterinarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspecialidadeVeterinario", x => new { x.EspecialidadesEspecialidadeId, x.VeterinariosVeterinarioId });
                    table.ForeignKey(
                        name: "FK_EspecialidadeVeterinario_tbl_Especialidades_EspecialidadesEspecialidadeId",
                        column: x => x.EspecialidadesEspecialidadeId,
                        principalTable: "tbl_Especialidades",
                        principalColumn: "id_Especialidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EspecialidadeVeterinario_tbl_Veterinarios_VeterinariosVeterinarioId",
                        column: x => x.VeterinariosVeterinarioId,
                        principalTable: "tbl_Veterinarios",
                        principalColumn: "id_Veterinario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Animais",
                columns: table => new
                {
                    id_Animal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ds_Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    id_Raca = table.Column<int>(type: "int", nullable: false),
                    tp_Sexo = table.Column<int>(type: "int", nullable: false),
                    dt_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vl_Peso = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ds_Cor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    id_Tutor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Animais", x => x.id_Animal);
                    table.ForeignKey(
                        name: "FK_tbl_Animais_tbl_Racas_id_Raca",
                        column: x => x.id_Raca,
                        principalTable: "tbl_Racas",
                        principalColumn: "id_Raca",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Animais_tbl_Tutores_id_Tutor",
                        column: x => x.id_Tutor,
                        principalTable: "tbl_Tutores",
                        principalColumn: "id_Tutor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Consultas",
                columns: table => new
                {
                    id_Consulta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dt_Consulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dt_Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dt_Fim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tp_Status = table.Column<int>(type: "int", nullable: false),
                    id_Animal = table.Column<int>(type: "int", nullable: false),
                    id_Veterinario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Consultas", x => x.id_Consulta);
                    table.ForeignKey(
                        name: "FK_tbl_Consultas_tbl_Animais_id_Animal",
                        column: x => x.id_Animal,
                        principalTable: "tbl_Animais",
                        principalColumn: "id_Animal",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_Consultas_tbl_Veterinarios_id_Veterinario",
                        column: x => x.id_Veterinario,
                        principalTable: "tbl_Veterinarios",
                        principalColumn: "id_Veterinario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Prontuarios",
                columns: table => new
                {
                    id_Prontuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dt_Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ds_DescricaoClinica = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ds_Diagnostico = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    id_Consulta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Prontuarios", x => x.id_Prontuario);
                    table.ForeignKey(
                        name: "FK_tbl_Prontuarios_tbl_Consultas_id_Consulta",
                        column: x => x.id_Consulta,
                        principalTable: "tbl_Consultas",
                        principalColumn: "id_Consulta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EspecialidadeVeterinario_VeterinariosVeterinarioId",
                table: "EspecialidadeVeterinario",
                column: "VeterinariosVeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Animais_id_Raca",
                table: "tbl_Animais",
                column: "id_Raca");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Animais_id_Tutor",
                table: "tbl_Animais",
                column: "id_Tutor");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Consultas_id_Animal",
                table: "tbl_Consultas",
                column: "id_Animal");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Consultas_id_Veterinario",
                table: "tbl_Consultas",
                column: "id_Veterinario");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Prontuarios_id_Consulta",
                table: "tbl_Prontuarios",
                column: "id_Consulta",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Racas_id_Especie",
                table: "tbl_Racas",
                column: "id_Especie");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tutores_id_Contato",
                table: "tbl_Tutores",
                column: "id_Contato",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_Tutores_id_Endereco",
                table: "tbl_Tutores",
                column: "id_Endereco",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EspecialidadeVeterinario");

            migrationBuilder.DropTable(
                name: "tbl_Prontuarios");

            migrationBuilder.DropTable(
                name: "tbl_Especialidades");

            migrationBuilder.DropTable(
                name: "tbl_Consultas");

            migrationBuilder.DropTable(
                name: "tbl_Animais");

            migrationBuilder.DropTable(
                name: "tbl_Veterinarios");

            migrationBuilder.DropTable(
                name: "tbl_Racas");

            migrationBuilder.DropTable(
                name: "tbl_Tutores");

            migrationBuilder.DropTable(
                name: "tbl_Especies");

            migrationBuilder.DropTable(
                name: "tbl_Contatos");

            migrationBuilder.DropTable(
                name: "tbl_Enderecos");
        }
    }
}
