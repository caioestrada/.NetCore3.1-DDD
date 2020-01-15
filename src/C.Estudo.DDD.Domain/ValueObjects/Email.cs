using Flunt.Validations;

namespace C.Estudo.DDD.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Address { get; private set; }

        public Email(string endereco)
        {
            Address = endereco;

            Validate();
        }

        private void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Address, "Email.Address", "Invalid Email Address")
            );
        }
    }
}
