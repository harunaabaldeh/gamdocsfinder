using Domain;
using FluentValidation;

namespace Application.Documents.Common
{
    public class DocumentValidator : AbstractValidator<Document>
    {
        public DocumentValidator()
        {
            RuleFor(x => x.DocumentName).NotEmpty();
            RuleFor(x => x.DocumentNumber).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.PlaceFound).NotEmpty();
            RuleFor(x => x.FounderName).NotEmpty();
            RuleFor(x => x.DateFound).NotEmpty();
        }
    }
}