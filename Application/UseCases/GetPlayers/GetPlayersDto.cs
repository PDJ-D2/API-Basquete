namespace BasqAPI.Application.UseCases.GetPlayers
{
    public class GetPlayersDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Position { get; init; }
        public double HeightCm { get; init; }
        public double WeightKg { get; init; }
        public bool IsActive { get; init; }
    }
}
