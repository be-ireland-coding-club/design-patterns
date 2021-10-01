using MediatorProject.Mediator;
using MediatorProject.Steps;
using System;

class QuantitySelectionStep : Step
{
	public QuantitySelectionStep(IMediator mediator): base(mediator)
    {
    }

    public void SelectQuantity()
    {
        Console.WriteLine("Selected quantity");
        _mediator.HandleStepCompletion(StepEnum.QuantitySelection);
    }
}