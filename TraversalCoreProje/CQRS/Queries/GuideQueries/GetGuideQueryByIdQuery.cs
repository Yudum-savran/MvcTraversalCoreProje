using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Queries.GuideQueries
{
    public class GetGuideQueryByIdQuery : IRequest<GetGuideQueryByIdResult>
    {
        public GetGuideQueryByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        
    }
}
