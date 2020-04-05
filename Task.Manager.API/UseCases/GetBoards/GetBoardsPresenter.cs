using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Task.Manager.Application.Boundaries;
using Task.Manager.Application.Boundaries.GetBoards;

namespace Task.Manager.API.UseCases.GetBoards
{
    public class GetBoardsPresenter : IPresenterOutputPort<GetBoardsOutput>, IPresenter<GetBoardsOutput>
    {
        public IActionResult ViewModel { get; set; }

        public void Output(GetBoardsOutput useCaseOutputPort)
        {
            if (useCaseOutputPort.Boards.Any())
            {
                ViewModel = new OkObjectResult(useCaseOutputPort);
            }
            else
            {
                ViewModel = new NotFoundResult();
            }
        }
    }
}
