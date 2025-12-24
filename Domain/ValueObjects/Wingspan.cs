using BasqAPI.Domain.Exceptions;

namespace BasqAPI.Domain.ValueObjects
{
    public sealed class Wingspan
    {
        public int Centimeters { get; }

        private Wingspan(int centimeters)
        {
            if (centimeters <= 0)
                throw new DomainException("Wingspan deve ser maior que zero.");

            Centimeters = centimeters;
        }

        public static Wingspan FromCentimeters(int centimeters)
        {
            return new Wingspan(centimeters);
        }

        public double ToFeet()
        {
            return Math.Round(Centimeters / 30.48, 2);
        }

        public string ToFeetAndInches()
        {
            var totalInches = Centimeters / 2.54;
            var feet = (int)(totalInches / 12);
            var inches = (int)(totalInches % 12);

            return $"{feet}'{inches}\"";
        }
    }
}
