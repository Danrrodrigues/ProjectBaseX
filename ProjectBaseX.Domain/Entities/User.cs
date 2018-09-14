namespace ProjectBaseX.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string AccessKey { get; set; }
    }
}
