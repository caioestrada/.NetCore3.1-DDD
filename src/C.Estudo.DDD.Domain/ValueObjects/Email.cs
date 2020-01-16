namespace C.Estudo.DDD.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Address { get; private set; }

        public Email(string endereco)
        {
            Address = endereco;
        }
    }
}
