namespace BasqAPI.Application.UseCases.GetPlayer
{
    public class GetPlayerDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public bool IsActive { get; set; }

        // Altura
        public int HeightCm { get; set; }
        public string HeightFeetInches { get; set; }

        // Peso
        public double WeightKg { get; set; }
        public double WeightLb { get; set; }

        // Wingspan
        public int WingspanCm { get; set; }
        public string WingspanFeetInches { get; set; }
    }
}
