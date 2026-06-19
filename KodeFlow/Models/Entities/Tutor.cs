using KodeFlow.Validations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

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
    [PrimeiraLetraMaiuscula] //Atributo personalizado
    public string Nome { get; set; } = string.Empty;

    [Required]
    [StringLength(14)]
    [Column("ds_CPF")]
    public string CPF { get; set; } = string.Empty;

    [JsonIgnore]
    public Contato Contato { get; set; } = null!;

    [JsonIgnore]
    public Endereco Endereco { get; set; } = null!;

    [JsonIgnore]
    public ICollection<Animal> Animais { get; set; } = new List<Animal>();

}
