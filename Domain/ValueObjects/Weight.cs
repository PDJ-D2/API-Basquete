using BasqAPI.Domain.Exceptions;

namespace BasqAPI.Domain.ValueObjects
{
    public sealed class Weight
    {
        public double Kilograms { get; }

        private Weight(double kilograms)
        {
            if (kilograms <= 0)
                throw new DomainException("Peso deve ser maior que zero.");

            Kilograms = kilograms;
        }

        public static Weight FromKilograms(double kilograms)
        {
            return new Weight(kilograms);
        }

        public double ToPounds()
        {
            return Math.Round(Kilograms * 2.20462, 2);
        }
    }
}
