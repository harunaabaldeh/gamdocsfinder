using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Documents.Common;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Documents.Queries
{
    public class DocumentQuery
    {
        public class Query : IRequest<Result<Document>>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Result<Document>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Document>> Handle(Query request, CancellationToken cancellationToken)
            {
                var document = await _context.Documents.FindAsync(request.Id);

                return Result<Document>.Success(document);
            }
        }

    }
}