using Flunt.Validations;

namespace C.Estudo.DDD.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            Validate();
        }

        private void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(FirstName, "Name.FirstName", "Inform First Name")
                .IsNotNullOrEmpty(LastName, "Name.LastName", "Inform Last Name")
            );
        }
    }
}
