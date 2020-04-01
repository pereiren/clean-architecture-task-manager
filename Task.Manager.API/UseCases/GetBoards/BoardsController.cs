using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Manager.Application.Boundaries.GetBoards;

namespace Task.Manager.API.UseCases.GetBoards
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class BoardsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BoardsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(Name ="GetBoards")]
        public async Task<IAsyncResult> Get()
        {
            var input = new GetBoardsInput();

        }
    }
}