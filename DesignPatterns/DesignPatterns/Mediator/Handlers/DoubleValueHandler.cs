using DesignPatterns.DesignPatterns.Mediator.Requests;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Mediator.Handlers
{
    class DoubleValueHandler : IRequestHandler<DoubleValue, int>
    {
        public async Task<int> Handle(DoubleValue request, CancellationToken cancellationToken = default(CancellationToken))
        {
            Console.WriteLine("DoubleValueHandler");
            Console.WriteLine($"Initial value: {request.Value}");
            Console.WriteLine($"Doubling the value{Environment.NewLine}");

            return await Task.FromResult(request.Value * 2);
        }
    }
}
