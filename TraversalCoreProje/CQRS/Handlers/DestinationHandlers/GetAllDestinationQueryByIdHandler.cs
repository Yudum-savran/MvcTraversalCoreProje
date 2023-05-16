using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.DestinationResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryByIdHandler
    {
        private readonly Context _context;

        public GetAllDestinationQueryByIdHandler(Context context)
        {
            _context = context;
        }

        public GetAllDestinationQueryIdResult Handle(GetAllDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetAllDestinationQueryIdResult
            {
                DestinationId = values.DestinationId,
                City = values.City,
                DayNight = values.DayNight,
                Price = values.Price
            };
        }
    }
}
