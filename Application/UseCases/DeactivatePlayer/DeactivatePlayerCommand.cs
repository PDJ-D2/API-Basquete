namespace BasqAPI.Application.UseCases.DeactivatePlayer
{
    public class DeactivatePlayerCommand
    {
        public Guid Id { get; }
        public DeactivatePlayerCommand(Guid id)
        {
            Id = id;
        }
    }
}
