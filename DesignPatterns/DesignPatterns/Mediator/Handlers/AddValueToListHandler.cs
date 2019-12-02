using DesignPatterns.DesignPatterns.Mediator.Requests;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Mediator.Handlers
{
    class AddValueToListHandler : IRequestHandler<AddValueToList, ICollection<int>>
    {
        public Task<ICollection<int>> HandleAsync(AddValueToList request, CancellationToken cancellationToken = default(CancellationToken))
        {
            Console.WriteLine("AddValueToListHandler");
            Console.WriteLine($"Initial list: {string.Join(", ", request.List)}");
            Console.WriteLine($"Adding '5' to list");

            var newList = new List<int>(request.List)
            {
                5
            };

            return Task.FromResult<ICollection<int>>(newList);
        }
    }
}
