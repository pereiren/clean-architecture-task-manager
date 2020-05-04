using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Task.Manager.Application.Boundaries.GetBoards;

namespace Task.Manager.API.UseCases.GetBoards
{
    public class GetBoardsPresenter : IPresenter<GetBoardsOutput>
    {
        public IActionResult ViewModel { get; set; }

        public IActionResult Output(GetBoardsOutput getBoardsOutput)
        {
            if (getBoardsOutput.Boards.Any())
            {
                var getBoardsResponse = new List<GetBoardsResponse>();

                foreach (var board in getBoardsOutput.Boards)
                {
                    var getBoardResponse = new GetBoardsResponse(board.Id, board.Name);
                    getBoardsResponse.Add(getBoardResponse);
                }

                ViewModel = new OkObjectResult(getBoardsResponse);
            }
            else
            {
                ViewModel = new NotFoundResult();
            }

            return ViewModel;
        }
    }
}
