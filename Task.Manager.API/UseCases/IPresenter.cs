using Microsoft.AspNetCore.Mvc;
using Task.Manager.Application.Boundaries;

namespace Task.Manager.API.UseCases
{
    public interface IPresenter<in TUseCaseOutPort> where TUseCaseOutPort: IUseCaseOutputPort
    {
        IActionResult Output(TUseCaseOutPort output);
    }
}
