using Application.Documents.Common;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.Documents.Commands
{
    public class CreateDocument
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Document Document { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Document).SetValidator(new DocumentValidator());
            }
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
                _context.Documents.Add(request.Document);

                var result = await _context.SaveChangesAsync() > 0;

                if (!result) return Result<Unit>.Failure("Failed to create activity");

                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}