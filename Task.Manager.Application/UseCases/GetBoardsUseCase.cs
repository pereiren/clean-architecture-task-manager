using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Task.Manager.Application.Boundaries;
using Task.Manager.Application.Boundaries.GetBoards;
using Task.Manager.Application.Services.Interfaces;

namespace Task.Manager.Application.UseCases
{
    public class GetBoardsUseCase : IUseCase<GetBoardsInput>
    {
        private readonly IBoardService _boardService;
        private readonly IPresenterOutputPort<GetBoardsOutput> _presenterOutputPort;

        public GetBoardsUseCase(IBoardService boardService, IPresenterOutputPort<GetBoardsOutput> presenterOutputPort)
        {
            _boardService = boardService;
            _presenterOutputPort = presenterOutputPort;
        }

        public async System.Threading.Tasks.Task Handle(GetBoardsInput useCaseInputPort)
        {
            try
            {
                var boards = await _boardService.GetBoards();

                var output = new GetBoardsOutput(boards);
                _presenterOutputPort.Output(output);

            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
