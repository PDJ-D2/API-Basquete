using BasqAPI.Domain.Entities;

namespace BasqAPI.Application.Abstractions
{
    public interface IPlayerRepository
    {
        Task AddAsync(Player player);
        Task UpdateAsync(Player player);
        Task<Player?> GetByIdAsync(Guid id);
    }
}
