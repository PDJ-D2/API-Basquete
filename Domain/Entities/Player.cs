using BasqAPI.Domain.Exceptions;
using BasqAPI.Domain.ValueObjects;

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
        public Height Height { get; private set; }
        public Weight Weight { get; private set; }
        public Wingspan Wingspan { get; private set; }

        public Player(string name, int age, string position, Height height, Weight weight, Wingspan wingspan)
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
            Height = height ?? throw new DomainException("Altura é obrigatória.");
            Weight = weight ?? throw new DomainException("Peso é obrigatório.");
            Wingspan = wingspan ?? throw new DomainException("Wingspan é obrigatória.");
            IsActive = true;
            TeamId = null;
        }

        public void Update(string name, int age, string position, Height height, Weight weight, Wingspan wingspan)
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
            Height = height ?? throw new DomainException("Altura é obrigatória.");
            Weight = weight ?? throw new DomainException("Peso é obrigatório.");
            Wingspan = wingspan ?? throw new DomainException("Wingspan é obrigatória.");
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
