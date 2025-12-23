using BasqAPI.Application.Abstractions;
using BasqAPI.Domain.Entities;

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
                command.Position
            );

            await _playerRepository.AddAsync(player);
        }
    }
}
