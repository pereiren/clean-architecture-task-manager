using Task.Manager.Application.Boundaries;

namespace Task.Manager.Application.UseCases
{
    public interface IUseCase<in TUseCaseInputPort> where TUseCaseInputPort  : IUseCaseInputPort
    {
        System.Threading.Tasks.Task<IUseCaseOutputPort> Handle(TUseCaseInputPort useCaseInputPort);
    }
}
