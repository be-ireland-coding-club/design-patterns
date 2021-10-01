using MediatorProject.Steps;

namespace MediatorProject.Mediator
{
    interface IMediator
    {
        void HandleStepCompletion(StepEnum step);
    }
}
