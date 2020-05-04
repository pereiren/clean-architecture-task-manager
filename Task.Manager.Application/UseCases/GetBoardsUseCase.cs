using Task.Manager.Application.Boundaries;
using Task.Manager.Application.Boundaries.GetBoards;
using Task.Manager.Application.Services.Interfaces;

namespace Task.Manager.Application.UseCases
{
    public class GetBoardsUseCase : IUseCase<GetBoardsInput>
    {
        private readonly IBoardService _boardService;
        private readonly IUseCaseOutputPort _outputPort;

        public GetBoardsUseCase(IBoardService boardService, IUseCaseOutputPort outputPort)
        {
            _boardService = boardService;
            _outputPort = outputPort;
        }

        public async System.Threading.Tasks.Task<IUseCaseOutputPort> Handle(GetBoardsInput useCaseInputPort)
        {
            IUseCaseOutputPort outputPort = null;

            var boards = await _boardService.GetBoards();

            outputPort = new GetBoardsOutput(boards);
            
            return outputPort;
        }
    }
}
