namespace MyBoilerplateDotNetCore6.Entities
{
    public class BaseEntity : IEntity
    {

        public int Id { get; set; }
        public DateTime TimeCreated { get; set; }
        public DateTime TimeUpdated { get; set; }

    }
}
