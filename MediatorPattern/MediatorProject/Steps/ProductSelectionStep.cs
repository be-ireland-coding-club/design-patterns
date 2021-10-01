using MediatorProject.Mediator;
using MediatorProject.Steps;
using System;

class ProductSelectionStep : Step
{
	public ProductSelectionStep(IMediator mediator): base(mediator)
    {
    }

    public void SelectProduct()
    {
        Console.WriteLine("Selected product");
        _mediator.HandleStepCompletion(StepEnum.ProductSelection);
    }
}