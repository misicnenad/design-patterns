using System.Collections.Generic;

namespace DesignPatterns.DesignPatterns.Mediator.Requests
{
    class AddValueToList : IRequest<ICollection<int>>
    {
        public ICollection<int> List;
    }
}
