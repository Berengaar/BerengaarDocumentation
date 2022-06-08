using ExceptionDoc.Entities.Abstract;

namespace ExceptionDoc.Entities.Concrete
{
    public class Movie : BaseEntity
    {
        public string? Subject { get; set; }
        public DateTime Date { get; set; }
        public List<string>? Actors { get; set; }
    }
}
