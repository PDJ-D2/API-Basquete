using BasqAPI.Domain.Exceptions;

namespace BasqAPI.Domain.Entities
{
    public class Player
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Position { get; private set; }
        public Guid? TeamId { get; private set; }
        public bool IsActive { get; private set; }

        public Player(string name, int age, string position)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException("Nome do jogador é necessário.");

            if (age <= 0)
                throw new DomainException("A idade do jogador deve ser maior que zero.");

            if (string.IsNullOrWhiteSpace(position))
                throw new DomainException("A posição do jogador é necessária.");

            Name = name;
            Age = age;
            Position = position;
            IsActive = true;
            TeamId = null;
        }

        public void Update(string name, int age, string position)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new DomainException("Nome do jogador é necessário.");
            if (age <= 0)
                throw new DomainException("A idade do jogador deve ser maior que zero.");
            if (string.IsNullOrWhiteSpace(position))
                throw new DomainException("A posição do jogador é necessária.");
            Name = name;
            Age = age;
            Position = position;
        }

        public void Deactivate()
        {
            if (!IsActive)
                throw new DomainException("O jogador já está inativo.");

            IsActive = false;
            TeamId = null;
        }
    }
}
