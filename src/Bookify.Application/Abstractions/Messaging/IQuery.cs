using Bookify.Domain.Abstractions;
using MediatR;

namespace Bookify.Application.Abstractions.Messaging
{
    /// <summary>
    /// marker interface that represents a read-only request
    /// We use IQuery<TResponse> to mark the request object (e.g., GetUserByIdQuery) as a query,
    /// not just any MediatR request. It’s about semantic clarity, consistency, 
    /// and enabling generic behaviors (like caching or logging) that only apply to queries.
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
