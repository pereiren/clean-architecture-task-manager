using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task.Manager.Application.Boundaries;

namespace Task.Manager.API.UseCases
{
    public interface IPresenter<in TUseCaseOutPort> where TUseCaseOutPort: IUseCaseOutputPort
    {
        IActionResult ViewModel { get; set; }
    }
}
