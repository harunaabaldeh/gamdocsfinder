using Application.Documents.Common;
using MediatR;
using Persistence;

namespace Application.Documents.Commands
{
    public class DeleteDocument
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Guid Id { get; set; }
        }


        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var document = await _context.Documents.FindAsync(request.Id);

                _context.Remove(document);

                var result = await _context.SaveChangesAsync() > 0;

                if (!result) return Result<Unit>.Failure("Failed to delete activity");

                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}