using DataAccessLayer.Concrete;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Queries.GuideQueries;
using TraversalCoreProje.CQRS.Results.GuideResults;

namespace TraversalCoreProje.CQRS.Handlers.GuideHandlers
{
    public class GetGuideQueryByIdHandler : IRequestHandler<GetGuideQueryByIdQuery, GetGuideQueryByIdResult>
    {
        private readonly Context _context;

        public GetGuideQueryByIdHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideQueryByIdResult> Handle(GetGuideQueryByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideQueryByIdResult
            {
                GuideId = values.GuideId,
                Description = values.Description,
                Name = values.Name
            };
        }
    }
}
