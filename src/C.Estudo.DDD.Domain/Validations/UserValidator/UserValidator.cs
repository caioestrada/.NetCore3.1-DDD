using C.Estudo.DDD.Domain.Entities;
using FluentValidation;

namespace C.Estudo.DDD.Domain.Validations.UserValidator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty();
            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.Email).EmailAddress();
        }
    }
}
