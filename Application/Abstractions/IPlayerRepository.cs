using BasqAPI.Domain.Entities;

namespace BasqAPI.Application.Abstractions
{
    public interface IPlayerRepository
    {
        Task AddAsync(Player player);
    }
}
