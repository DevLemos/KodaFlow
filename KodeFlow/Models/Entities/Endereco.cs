using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace KodeFlow.Models.Entities;

[Table("tbl_Enderecos")]
public class Endereco
{
    [Key]
    [Column(name: "id_Endereco")]
    public int EnderecoId { get; set; }

    [Required]
    [StringLength(200)]
    [Column(name: "ds_Rua")]
    public string Rua { get; set; } = string.Empty;

    [Required]
    [StringLength(10)]
    [Column(name: "ds_Numero")]
    public string Numero { get; set; } = string.Empty;

    [StringLength(100)]
    [Column(name: "ds_Complemento")]
    public string? Complemento { get; set; }

    [Required]
    [StringLength(100)]
    [Column(name: "ds_Bairro")]
    public string Bairro { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    [Column(name: "ds_Cidade")]
    public string Cidade { get; set; } = string.Empty;

    [Required]
    [StringLength(2)]
    [Column(name: "ds_Estado", TypeName = "char(2)")]
    public string Estado { get; set; } = string.Empty;

    [Required]
    [StringLength(9)]
    [Column(name: "ds_Cep", TypeName = "char(9)")]
    public string CEP { get; set; } = string.Empty;

    [ForeignKey(nameof(Tutor))]
    [Column(name: "id_Tutor")]
    public int TutorId { get; set; }

    [JsonIgnore]
    public Tutor? Tutor { get; set; }
}
