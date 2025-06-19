using MediatR;
using System.Transactions;

namespace Bookify.Domain.Abstractions
{
    public interface IDomainEvent : INotification
    {
    }
}
