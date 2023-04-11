namespace cleanarch.Domain.Validation
{
    /// <summary>
    /// CLASSE RESPONSÁVEL POR TRATAR EXCEÇÕES NO DOMINIO.
    /// </summary>
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error)
        {}

        public static void When(bool hasError, string error)
        {
            if(hasError)
                throw new DomainExceptionValidation(error);
        }
    }
}
