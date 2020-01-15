using Flunt.Validations;

namespace C.Estudo.DDD.Domain.Entities
{
    public partial class User : Entity
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public User(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;

            Validate();
        }

        private void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(FirstName, "User.FirstName", "Inform First Name")
                .IsNotNullOrEmpty(LastName, "User.LastName", "Inform Last Name")
                .IsEmail(Email, "User.Email", "Invalid Email")
            );
        }
    }
}
