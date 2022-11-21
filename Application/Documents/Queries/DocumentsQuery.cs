using Application.Documents.Common;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Documents.Queries
{
    public class DocumentsQuery
    {
        public class Query : IRequest<Result<List<Document>>> { }

        public class Handler : IRequestHandler<Query, Result<List<Document>>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<List<Document>>> Handle(Query request, CancellationToken cancellationToken)
            {
                // return await _context.Documents.ToListAsync();
                return Result<List<Document>>.Success(await _context.Documents.ToListAsync());
            }
        }
    }
}