namespace Tournament.Domain.Entities
{
    public class Team : BaseEntity
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }

    }
}