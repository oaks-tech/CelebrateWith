namespace OakTech.CelebrateWith.Data.Entities
{
    public record Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
