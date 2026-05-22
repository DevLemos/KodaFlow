using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodeFlow.Models.Entities;

[Table("tbl_Especialidades")]
public class Especialidade
{
    [Key]
    [Column(name: "id_Especialidade")]
    public int EspecialidadeId { get; set; }

    [Required]
    [StringLength(150)]
    [Column(name: "ds_Nome")]
    public string Nome { get; set; } = string.Empty;

    [StringLength(300)]
    [Column(name: "ds_Descricao")]
    public string Descricao { get; set; } = string.Empty;
    public ICollection<Veterinario> Veterinarios { get; set; } = new List<Veterinario>();
}
