using BasqAPI.Domain.Exceptions;
using BasqAPI.Application.Abstractions;

namespace BasqAPI.Application.UseCases.UpdatePlayer
{
    public class UpdatePlayerHandler
    {
        private readonly IPlayerRepository _playerRepository;
        public UpdatePlayerHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public async Task HandleAsync(UpdatePlayerCommand command)
        {
            var player = await _playerRepository.GetByIdAsync(command.Id);
            if (player == null)
            {
                throw new DomainException("Jogador não encontrado.");
            }
            player.Update(command.Name, command.Age, command.Position);
            await _playerRepository.UpdateAsync(player);
        }
    }
}
