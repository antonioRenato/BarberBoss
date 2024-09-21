namespace BarberBoss.Exception.ExceptionsBase
{
    public class ErrorBaseException : BarberBossException
    {
        public List<string> Errors { get; set; }

        public ErrorBaseException(List<string> errorMessages)
        {
            Errors = errorMessages;
        }
    }
}
