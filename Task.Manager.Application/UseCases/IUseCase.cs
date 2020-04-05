using Task.Manager.Application.Boundaries;
using Task.Manager.Domain;

namespace Task.Manager.Application.UseCases
{
    public interface IUseCase<in TUseCaseInputPort> where TUseCaseInputPort  : IUseCaseInputPort
    {
        System.Threading.Tasks.Task Handle(TUseCaseInputPort useCaseInputPort);
    }
}
