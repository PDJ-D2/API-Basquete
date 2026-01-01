using BasqAPI.Application.Abstractions;
using BasqAPI.Domain.Exceptions;

namespace BasqAPI.Application.UseCases.GetPlayer
{
    public class GetPlayerHandler
    {
        private readonly IPlayerRepository _playerRepository;

        public GetPlayerHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<GetPlayerDto> HandleAsync(GetPlayerQuery query)
        {
            var player = await _playerRepository.GetByIdAsync(query.PlayerId);

            if (player is null)
                throw new DomainException("Jogador não encontrado.");

            return new GetPlayerDto
            {
                Id = player.Id,
                Name = player.Name,
                Age = player.Age,
                Position = player.Position,
                IsActive = player.IsActive,

                HeightCm = player.Height.Centimeters,
                HeightFeetInches = player.Height.ToFeetAndInches(),

                WeightKg = player.Weight.Kilograms,
                WeightLb = player.Weight.ToPounds(),

                WingspanCm = player.Wingspan.Centimeters,
                WingspanFeetInches = player.Wingspan.ToFeetAndInches()
            };
        }
    }
}
