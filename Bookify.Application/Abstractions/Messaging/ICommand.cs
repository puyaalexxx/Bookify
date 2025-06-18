using Bookify.Domain.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Application.Abstractions.Messaging
{
    /// <summary>
    /// Enforce that all our commands to return a Result type.
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface ICommand : IRequest<Result>, IBaseCommand
    {
    }

    /// <summary>
    /// Enforce that all our commands to return a Result<TResponse> type.
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
    {
    }

    /// <summary>
    /// Apply Generic constraints in our pipeline behaviors
    /// </summary>
    public interface IBaseCommand
    {

    }
}
