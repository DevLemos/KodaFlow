using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodeFlow.Models.Entities;

[Table("tbl_Veterinarios")]
public class Veterinario
{
    [Key]
    [Column(name: "id_Veterinario")]
    public int VeterinarioId { get; set; }

    [Required]
    [StringLength(150)]
    [Column(name: "ds_Nome")]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [StringLength(30)]
    [Column(name: "nr_Crmv")]
    public string CRMV { get; set; } = string.Empty;

    public ICollection<Consulta> Consultas { get; private set; } = new List<Consulta>();
    public ICollection<Especialidade> Especialidades { get; set; } = new List<Especialidade>();
}
