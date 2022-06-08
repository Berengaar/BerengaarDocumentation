namespace ExceptionDoc.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
