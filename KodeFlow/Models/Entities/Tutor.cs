using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KodeFlow.Models.Entities;

[Table("tbl_Tutores")]
public class Tutor
{
    [Key]
    [Column(name: "id_Tutor")]
    public int TutorId { get; set; }

    [Required]
    [StringLength(255)]
    [Column(name: "ds_Nome")]
    public string Nome { get; set; } = string.Empty;

    [Required]
    [StringLength(14)]
    [Column("ds_CPF")]
    public string CPF { get; set; } = string.Empty;

    [ForeignKey(nameof(Contato))]
    [Column("id_Contato")]
    public int ContatoId { get; set; }
    public Contato Contato { get; set; } = null!;

    [ForeignKey(nameof(Endereco))]
    [Column("id_Endereco")]
    public int EnderecoId { get; set; }
    public Endereco Endereco { get; set; } = null!;
    public ICollection<Animal> Animais { get; set; } = new List<Animal>();

}
