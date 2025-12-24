namespace BasqAPI.Application.UseCases.DeactivatePlayer
{
    public class DeactivatePlayerCommand
    {
        public int Id { get; }
        public DeactivatePlayerCommand(int id)
        {
            Id = id;
        }
    }
}
