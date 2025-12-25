using FluentValidation;

namespace BasqAPI.Application.UseCases.CreatePlayer
{
    public class CreatePlayerValidator : AbstractValidator<CreatePlayerCommand>
    {
        private static readonly string[] ValidPositions =
        {
            "Armador",
            "Ala-armador",
            "Ala",
            "Ala-pivô",
            "Pivô"
        };
        public CreatePlayerValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("O nome é necessário.")
                .MaximumLength(150).WithMessage("O nome não pode exceder 150 caracteres.");
            RuleFor(x => x.Age)
                .InclusiveBetween(17, 50).WithMessage("Idade deve ser entre 17 e 50.");
            RuleFor(x => x.Position)
                .NotEmpty().WithMessage("Posição é necessária.")
                .Must(pos => ValidPositions.Contains(pos))
                .WithMessage("Posição deve ser uma a seguir: Armador, Ala-armador, Ala, Ala-pivô, Pivô");
            RuleFor(x => x.HeightCm)
                .GreaterThan(0).WithMessage("Altura deve ser maior que zero.");
            RuleFor(x => x.WeightKg)
                .GreaterThan(0).WithMessage("Peso deve ser maior que zero.");
            RuleFor(x => x.WingspanCm)
                .GreaterThan(0).WithMessage("Wingspan deve ser maior que zero.");
        }
    }
}