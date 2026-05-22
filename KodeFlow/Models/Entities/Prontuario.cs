using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodeFlow.Models.Entities;

[Table("tbl_Prontuarios")]
public class Prontuario
{
    [Key]
    [Column(name: "id_Prontuario")]
    public int ProntuarioId { get; set; }

    [Required]
    [Column(name: "dt_Inicio")]
    public DateTime DataInicio { get; set; }

    [StringLength(300)]
    [Column(name: "ds_DescricaoClinica")]
    public string DescricaoClinica { get; set; } = string.Empty;

    [StringLength(255)]
    [Column(name: "ds_Diagnostico")]
    public string Diagnostico { get; set; } = string.Empty;

    [ForeignKey(nameof(Consulta))]
    [Column(name: "id_Consulta")]
    public int ConsultaId { get; set; }
    public Consulta Consulta { get; set; } = null!;
}
