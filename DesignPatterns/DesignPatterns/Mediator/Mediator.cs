using DesignPatterns.DesignPatterns.Mediator.Handlers;
using DesignPatterns.DesignPatterns.Mediator.Requests;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Mediator
{
    class Mediator : IMediator
    {
        ConcurrentDictionary<Type, object> _handlers = new ConcurrentDictionary<Type, object>();

        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var handlerType = typeof(Mediator).Assembly.GetTypes()
                .Where(t => !t.IsInterface && !t.IsAbstract
                    && t.GetInterfaces().Any(i => i.IsGenericType
                    && typeof(IRequestHandler<,>).IsAssignableFrom(i.GetGenericTypeDefinition())
                    && i.GetGenericArguments().Any(a => a == request.GetType())))
                .SingleOrDefault();

            var handler = _handlers.GetOrAdd(request.GetType(), t => Activator.CreateInstance(handlerType));

            var handlerMethod = handlerType?.GetMethod("Handle");
            
            return (Task<TResponse>)handlerMethod.Invoke(handler, new object[] { request, cancellationToken });
        }
    }
}
