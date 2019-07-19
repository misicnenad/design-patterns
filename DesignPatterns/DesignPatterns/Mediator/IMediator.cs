using DesignPatterns.DesignPatterns.Mediator.Requests;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Mediator
{
    interface IMediator
    {
        Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
