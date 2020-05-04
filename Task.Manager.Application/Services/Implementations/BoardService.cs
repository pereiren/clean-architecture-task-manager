using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Manager.Application.Services.Interfaces;
using Task.Manager.Domain.Boards;

namespace Task.Manager.Application.Services.Implementations
{
    public class BoardService : IBoardService
    {
        private readonly IBoardRepository _boardRepository;

        public BoardService(IBoardRepository boardRepository)
        {
            _boardRepository = boardRepository;
        }

        public async Task<IEnumerable<Board>> GetBoards()
        {
            var boards = await System.Threading.Tasks.Task.Run(() => _boardRepository.FindAll());

            return boards;
        }
    }
}
