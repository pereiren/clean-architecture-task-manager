using System.Collections.Generic;
using System.Threading.Tasks;
using Task.Manager.Domain.Boards;

namespace Task.Manager.Application.Services.Interfaces
{
    public interface IBoardService
    {
        Task<IEnumerable<Board>> GetBoards(); 
    }
}
