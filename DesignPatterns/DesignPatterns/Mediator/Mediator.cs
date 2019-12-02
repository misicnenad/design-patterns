using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DesignPatterns.DesignPatterns.Mediator.Handlers;
using DesignPatterns.DesignPatterns.Mediator.Requests;

namespace DesignPatterns.DesignPatterns.Mediator
{
    internal class Mediator : IMediator
    {
        private ConcurrentDictionary<Type, object> _handlers = new ConcurrentDictionary<Type, object>();

        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var handlerType = GetType().Assembly.GetTypes()
                .Where(t => !t.IsInterface && !t.IsAbstract
                    && t.GetInterfaces().Any(i => i.IsGenericType
                        && typeof(IRequestHandler<,>).IsAssignableFrom(i.GetGenericTypeDefinition())
                    && i.GetGenericArguments().Any(a => a == request.GetType())))
                .SingleOrDefault();

            var handler = _handlers.GetOrAdd(request.GetType(), t => Activator.CreateInstance(handlerType));

            var handlerMethod = handlerType?.GetMethod(nameof(IRequestHandler<IRequest<TResponse>,TResponse>.HandleAsync));

            return (Task<TResponse>) handlerMethod.Invoke(handler, new object[] { request, cancellationToken });
        }
    }
}
