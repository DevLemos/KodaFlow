using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KodeFlow.Models.Entities;

[Table("tbl_Contatos")]
public class Contato
{
    [Key]
    [Column(name: "id_Contato")]
    public int ContatoId { get; set; }

    [StringLength(20)]
    [Column(name: "nr_Telefone")]
    public string? Telefone { get; set; }

    [Required]
    [StringLength(20)]
    [Column(name: "nr_Celular")]
    public string Celular { get; set; } = string.Empty;

    [Required]
    [StringLength(255)]
    [EmailAddress]
    [Column(name: "ds_Email")]
    public string Email { get; set; } = string.Empty;

    [ForeignKey(nameof(Tutor))]
    [Column(name: "id_Tutor")]
    public int TutorId { get; set; }
    public Tutor? Tutor { get; set; }

}
