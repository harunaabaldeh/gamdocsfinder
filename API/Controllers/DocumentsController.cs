using Application.Documents.Commands;
using Application.Documents.Queries;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class DocumentsController : BaseApiController
    {

        [HttpGet]
        public async Task<IActionResult> GetDocuments()
        {
            return HandleResult(await Mediator.Send(new DocumentsQuery.Query()));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocument(Guid id)
        {
            return HandleResult(await Mediator.Send(new DocumentQuery.Query { Id = id }));

        }

        [HttpPost]
        public async Task<IActionResult> AddDocument(Document document)
        {
            return HandleResult(await Mediator.Send(new CreateDocument.Command { Document = document }));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> EditDocument(Guid id, Document document)
        {
            document.Id = id;

            return HandleResult(await Mediator.Send(new UpdateDocument.Command { Document = document }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(Guid id)
        {
            return HandleResult(await Mediator.Send(new DeleteDocument.Command { Id = id }));
        }
    }
}