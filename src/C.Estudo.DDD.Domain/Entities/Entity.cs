using Flunt.Notifications;
using System;

namespace C.Estudo.DDD.Domain.Entities
{
    public class Entity : Notifiable
    {
        public Guid? Id { get; set; }
    }
}
