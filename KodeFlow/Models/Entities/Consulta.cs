using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KodeFlow.Domain.Enums;

namespace KodeFlow.Models.Entities;

[Table("tbl_Consultas")]
public class Consulta
{
    [Key]
    [Column(name: "id_Consulta")]
    public int ConsultaId { get; set; }

    [Column(name: "dt_Consulta")]
    public DateTime DataConsulta { get; set; }

    [Column(name: "dt_Inicio")]
    public DateTime DataInicio { get; set; }

    [Column(name: "dt_Fim")]
    public DateTime DataFim { get; set; }

    [Column(name: "tp_Status", TypeName = "int")]
    public StatusConsulta Status {  get; set; }

    [ForeignKey(nameof(Animal))]
    [Column(name: "id_Animal")]
    public int AnimalId { get; set; }
    public Animal Animal { get; set; } = null!;

    [ForeignKey(nameof(Veterinario))]
    [Column(name: "id_Veterinario")]
    public int VeterinarioId { get; set; }
    public Veterinario Veterinario { get; set; } = null!;
    public Prontuario Prontuario { get; set; } = null!;
}
