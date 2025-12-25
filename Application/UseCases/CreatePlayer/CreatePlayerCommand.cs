namespace BasqAPI.Application.UseCases.CreatePlayer
{
    public class CreatePlayerCommand
    {
        public string Name { get; }
        public int Age { get; }
        public string Position { get; }
        public int HeightCm { get; set; }
        public double WeightKg { get; set; }
        public int WingspanCm { get; set; }

        public CreatePlayerCommand(string name, int age, string position, int heightCm, double weightKg, int wingspanCm)
        {
            Name = name;
            Age = age;
            Position = position;
            HeightCm = heightCm;
            WeightKg = weightKg;
            WingspanCm = wingspanCm;
        }
    }
}
