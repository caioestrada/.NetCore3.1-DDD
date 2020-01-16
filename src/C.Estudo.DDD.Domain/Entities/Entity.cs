using FluentValidation.Results;
using System;
using System.Collections.Generic;

namespace C.Estudo.DDD.Domain.Entities
{
    public class Entity
    {
        public Guid? Id { get; set; }
        public bool Valid { get; set; }
        public bool Invalid { get; set; }
        public IList<string> Notifications { get; set; }

        public Entity() => Notifications = new List<string>();

        protected void Validate(ValidationResult validationResult)
        {
            if (validationResult.IsValid)
            {
                ValidateEntity();
                return;
            }

            InvalidateEntity(validationResult);
        }

        private void InvalidateEntity(ValidationResult validationResult)
        {
            Valid = false;
            Invalid = true;
            foreach (var failure in validationResult.Errors)
                Notifications.Add(failure.ErrorMessage);
        }

        private void ValidateEntity()
        {
            Valid = true;
            Invalid = false;
        }
    }
}
