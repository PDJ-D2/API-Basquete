namespace BasqAPI.Application.UseCases.UpdatePlayer
{
    public class UpdatePlayerCommand
    {
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }
        public string Position { get; }
        public UpdatePlayerCommand(int id, string name, int age, string position)
        {
            Id = id;
            Name = name;
            Age = age;
            Position = position;
        }
    }
}
