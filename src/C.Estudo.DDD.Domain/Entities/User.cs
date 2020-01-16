using C.Estudo.DDD.Domain.Validations.UserValidator;

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

            Validate(new UserValidator().Validate(this));
        }
    }
}
