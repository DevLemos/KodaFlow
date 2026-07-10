using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace KodeFlow.Models.Entities;

[Table("tbl_Tutores")]
public class Tutor : IValidatableObject
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

    //[JsonIgnore]
    public Contato Contato { get; set; } = null!;

    //[JsonIgnore]
    public Endereco Endereco { get; set; } = null!;

    [JsonIgnore]
    public ICollection<Animal> Animais { get; set; } = new List<Animal>();

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (!string.IsNullOrEmpty(this.Nome))
        {
            string primeiraLetra = this.Nome[0].ToString();

            if (primeiraLetra != primeiraLetra.ToUpper())
            {
                yield return new ValidationResult("A primeira letra do nome deve ser maiúscula", new[] {nameof(this.Nome)});
            }
        }
    }
}
