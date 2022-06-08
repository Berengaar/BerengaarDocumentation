namespace ExceptionDoc.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException():base("Movies not found") { }
        
    }
}
