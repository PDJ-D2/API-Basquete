using BasqAPI.Application.Abstractions;
using BasqAPI.Domain.Exceptions;

namespace BasqAPI.Application.UseCases.DeactivatePlayer
{
    public class DeactivatePlayerHandler
    {
        private readonly IPlayerRepository _playerRepository;
        public DeactivatePlayerHandler(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }
        public async Task HandleAsync(DeactivatePlayerCommand command)
        {
            var player = await _playerRepository.GetByIdAsync(command.Id);
            if (player == null)
            {
                throw new DomainException("Jogador não encontrado.");
            }
            // Assuming Player entity has a Deactivate method
            player.Deactivate();
            await _playerRepository.UpdateAsync(player);
        }
    }
}
