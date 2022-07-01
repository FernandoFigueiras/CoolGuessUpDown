namespace CoolGuessUpDown.Core.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Turn { get; set; }

        public int Points { get; private set; }

        public int GetGameRank() => Points;
    }
}
