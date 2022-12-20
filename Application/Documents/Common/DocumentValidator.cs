using Domain;
using FluentValidation;

namespace Application.Documents.Common
{
    public class DocumentValidator : AbstractValidator<Document>
    {
        public DocumentValidator()
        {
            RuleFor(x => x.DocumentName).NotEmpty();
            RuleFor(x => x.FounderFullName).NotEmpty();
            RuleFor(x => x.FounderPhoneNumber).NotEmpty();
            RuleFor(x => x.FounderAddress).NotEmpty();
            RuleFor(x => x.OwnerFullName).NotEmpty();
            RuleFor(x => x.DocumentNumber).NotEmpty();
            RuleFor(x => x.PlaceFound).NotEmpty();
            RuleFor(x => x.DateFound).NotEmpty();
        }
    }
}