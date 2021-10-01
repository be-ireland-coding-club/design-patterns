using MediatorProject.Mediator;
using MediatorProject.Steps;
using System;

class OrderPlacementStep : Step
{
	public OrderPlacementStep(IMediator mediator): base(mediator)
    {
    }

    public void PlaceOrder()
    {
        Console.WriteLine("Placed order\n---------------");
        _mediator.HandleStepCompletion(StepEnum.OrderPlacement);
    }
}