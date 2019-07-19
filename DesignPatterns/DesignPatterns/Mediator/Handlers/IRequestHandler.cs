using DesignPatterns.DesignPatterns.Mediator.Requests;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Mediator.Handlers
{
    interface IRequestHandler<in TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
