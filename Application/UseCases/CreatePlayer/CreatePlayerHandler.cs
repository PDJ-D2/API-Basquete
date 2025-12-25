using BasqAPI.Application.Abstractions;
using BasqAPI.Domain.Entities;
using BasqAPI.Domain.ValueObjects;

namespace BasqAPI.Application.UseCases.CreatePlayer
{
    public class CreatePlayerHandler
    {
        private readonly IPlayerRepository _playerRepository;

        public CreatePlayerHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task HandleAsync(CreatePlayerCommand command)
        {
            var player = new Player(
                command.Name,
                command.Age,
                command.Position,
                Height.FromCentimeters(command.HeightCm),
                Weight.FromKilograms(command.WeightKg),
                Wingspan.FromCentimeters(command.WingspanCm)
            );

            await _playerRepository.AddAsync(player);
        }
    }
}
