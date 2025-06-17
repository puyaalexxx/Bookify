using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Users.Events
{
    public record class UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
}
