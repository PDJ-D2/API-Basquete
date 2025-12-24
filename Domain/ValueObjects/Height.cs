using BasqAPI.Domain.Exceptions;

namespace BasqAPI.Domain.ValueObjects
{
    public sealed class Height
    {
        public int Centimeters { get; }

        private Height(int centimeters)
        {
            if (centimeters <= 0)
                throw new DomainException("Altura deve ser maior que zero.");

            Centimeters = centimeters;
        }

        public static Height FromCentimeters(int centimeters)
        {
            return new Height(centimeters);
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
