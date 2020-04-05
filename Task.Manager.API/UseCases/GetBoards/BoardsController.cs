using System.Threading.Tasks;
using FluentMediator;
using Microsoft.AspNetCore.Mvc;
using Task.Manager.Application.Boundaries.GetBoards;

namespace Task.Manager.API.UseCases.GetBoards
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class BoardsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IPresenter<GetBoardsOutput> _presenter;

        public BoardsController(IMediator mediator, IPresenter<GetBoardsOutput> presenter)
        {
            _mediator = mediator;
            _presenter = presenter;
        }

        [HttpGet(Name ="GetBoards")]
        public async Task<IActionResult> Get()
        {
            var input = new GetBoardsInput();
            await _mediator.PublishAsync(input);

            return _presenter.ViewModel;
        }
    }
}