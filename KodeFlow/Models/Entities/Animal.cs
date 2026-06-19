using KodeFlow.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace KodeFlow.Models.Entities;

[Table("tbl_Animais")]
public class Animal
{
    [Key]
    [Column("id_Animal")]
    public int AnimalId { get; set; }

    [Required]
    [StringLength(150)]
    [Column("ds_Nome")]
    public string Nome { get; set; } = string.Empty;

    [ForeignKey(nameof(Raca))]
    [Column("id_Raca")]
    public int RacaId { get; set; }
    public Raca Raca { get; set; } = null!;

    [Required]
    [Column("tp_Sexo")]
    public SexoAnimal Sexo { get; set; }

    [Column("dt_Nascimento")]
    public DateTime DataNascimento { get; set; }

    [Column("vl_Peso", TypeName = "decimal(10,2)")]
    public decimal Peso { get; set; }

    [StringLength(100)]
    [Column("ds_Cor")]
    public string Cor { get; set; } = string.Empty;

    [ForeignKey(nameof(Tutor))]
    [Column("id_Tutor")]
    public int TutorId { get; set; }
    public Tutor Tutor { get; set; } = null!;

    [JsonIgnore]
    public ICollection<Consulta> Consultas { get; private set; } = new List<Consulta>();
}