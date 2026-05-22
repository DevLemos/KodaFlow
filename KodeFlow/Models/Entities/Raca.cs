using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodeFlow.Models.Entities;

[Table("tbl_Racas")]
public class Raca
{
    [Key]
    [Column("id_Raca")]
    public int RacaId { get; set; }

    [Required]
    [StringLength(150)]
    [Column("ds_Nome")]
    public string Nome { get; set; } = string.Empty;

    [ForeignKey(nameof(Especie))]
    [Column("id_Especie")]
    public int EspecieId { get; set; }
    public Especie Especie { get; set; } = null!;

    public ICollection<Animal> Animais { get; private set; } = new List<Animal>();
}