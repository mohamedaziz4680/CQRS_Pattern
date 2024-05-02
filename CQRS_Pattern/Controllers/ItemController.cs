using CQRS_Layer.CQRSFolder.Commands;
using CQRS_Layer.CQRSFolder.Queries;
using CQRS_Layer.Data.Models;
using CQRS_Layer.Repos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepo _itemRepo;
        private readonly IMediator _mediator;

        public ItemController(IItemRepo itemRepo, IMediator mediator)
        {
            _itemRepo = itemRepo;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var ressult = await _mediator.Send(new GetAllItemsQuery());
            return Ok(ressult);
        }

        [HttpPost]
        public async Task<IActionResult> InsertItem(Item item)
        {
            var result = await _mediator.Send(new InsertItemCommand(item));
            return Ok(result);
        }
        
    }
}
