using MediatorProject.Mediator;
using MediatorProject.Steps;
using System;

class OrderCreationMediator : IMediator
{
	ProductSelectionStep _productSelectionStep;
    QuantitySelectionStep _quantitySelectionStep;
    OrderPlacementStep _orderPlacementStep;

    public OrderCreationMediator()
    {
		_productSelectionStep = new ProductSelectionStep(this);
        _quantitySelectionStep = new QuantitySelectionStep(this);
        _orderPlacementStep = new OrderPlacementStep(this);
    }

	public void CreateOrder()
    {
        Console.WriteLine("Creating Order:");
		_productSelectionStep.SelectProduct();
    }

	public void HandleStepCompletion(StepEnum step)
	{
        switch (step)
        {
            case StepEnum.ProductSelection:
                _quantitySelectionStep.SelectQuantity();
                break;
            case StepEnum.QuantitySelection:
                _orderPlacementStep.PlaceOrder();
                break;
            case StepEnum.OrderPlacement:
                return;
        }
    }
}