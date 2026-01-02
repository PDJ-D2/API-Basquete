using BasqAPI.Application.Abstractions;

namespace BasqAPI.Application.UseCases.GetPlayers
{
    public class GetPlayersHandler
    {
        private readonly IPlayerRepository _playerRepository;
        public GetPlayersHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public async Task<IReadOnlyList<GetPlayersDto>> HandleAsync(GetPlayersQuery query)
        {
            var players = await _playerRepository.GetAllAsync(query.OnlyActive);
            return players.Select(player => new GetPlayersDto
            {
                Id = player.Id,
                Name = player.Name,
                Position = player.Position,
                HeightCm = player.Height.Centimeters,
                WeightKg = player.Weight.Kilograms,
                IsActive = player.IsActive
            }).ToList();
        }
    }
}
