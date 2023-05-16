using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.CQRS.Queries.DestinationQueries
{
    public class GetAllDestinationByIdQuery
    {
        public GetAllDestinationByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

       
    }
}
