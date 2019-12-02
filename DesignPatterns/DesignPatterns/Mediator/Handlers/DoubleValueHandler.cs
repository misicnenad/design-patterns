using DesignPatterns.DesignPatterns.Mediator.Requests;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Mediator.Handlers
{
    class DoubleValueHandler : IRequestHandler<DoubleValue, int>
    {
        private const int _multiplier = 2;

        public Task<int> HandleAsync(DoubleValue request, CancellationToken cancellationToken = default(CancellationToken))
        {
            Console.WriteLine("DoubleValueHandler");
            Console.WriteLine($"Initial value: {request.Value}");
            Console.WriteLine($"Doubling the value");

            return Task.FromResult(request.Value * _multiplier);
        }
    }
}
