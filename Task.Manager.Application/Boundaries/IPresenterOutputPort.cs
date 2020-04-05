using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Manager.Application.Boundaries
{
    public interface IPresenterOutputPort<in TUseCaseOutputPort> where TUseCaseOutputPort : IUseCaseOutputPort
    {
        void Output(TUseCaseOutputPort useCaseOutputPort);
    }
}
