using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodeFlow.Models.Entities;

[Table("tbl_Especies")]
public class Especie
{
    [Key]
    [Column(name: "id_Especie")]
    public int EspecieId { get; set; }

    [Required]
    [StringLength(80)]
    [Column(name: "ds_Nome")]
    public string Nome { get; set; } = string.Empty;

    [StringLength(80)]
    [Column(name: "ds_NomeCientifico")]
    public string NomeCientifico { get; set; } = string.Empty;
    public ICollection<Raca> Racas { get; set; } = new List<Raca>();
}
