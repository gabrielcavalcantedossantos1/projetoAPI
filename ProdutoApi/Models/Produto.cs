using System.ComponentModel.DataAnnotations;

namespace ProdutoApi.Models;

public class Produto : IValidatableObject
{
    public required int Codigo { get; set; }

    public required string Nome { get; set; }

    public required decimal Valor { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (string.IsNullOrWhiteSpace(Nome))
        {
            yield return new ValidationResult(
                "O nome é obrigatório.",
                [nameof(Nome)]);
        }

        if (Valor <= 0)
        {
            yield return new ValidationResult(
                "O valor deve ser maior que zero.",
                [nameof(Valor)]);
        }
    }
}
