using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Comments.DestinationComments;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;

        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateDestinationComnand comnand)
        {
            _context.Destinations.Add(new Destination
            {
                City = comnand.City,
                Price = comnand.Price,
                Capacity = comnand.Capacity,
                DayNight = comnand.DayNight,
                Status = true
            });

            _context.SaveChanges();
        }
    }
}
