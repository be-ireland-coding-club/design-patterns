using MediatorProject.Mediator;
using MediatorProject.Steps;
using System;

class OrderEditMediator : IMediator
{
	ProductSelectionStep _productSelectionStep;
    OrderPlacementStep _orderPlacementStep;

    public OrderEditMediator()
    {
		_productSelectionStep = new ProductSelectionStep(this);
        _orderPlacementStep = new OrderPlacementStep(this);
    }

	public void EditOrder()
    {
        Console.WriteLine("Editing Order:");
        _productSelectionStep.SelectProduct();
    }

	public void HandleStepCompletion(StepEnum step)
	{
        switch (step)
        {
            case StepEnum.ProductSelection:
                _orderPlacementStep.PlaceOrder();
                break;
            case StepEnum.OrderPlacement:
                return;
        }
    }
}