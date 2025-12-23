namespace BasqAPI.Application.UseCases.CreatePlayer
{
    public class CreatePlayerCommand
    {
        public string Name { get; }
        public int Age { get; }
        public string Position { get; }

        public CreatePlayerCommand(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;
        }
    }
}
