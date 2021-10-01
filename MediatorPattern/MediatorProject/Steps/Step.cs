using MediatorProject.Mediator;

abstract class Step
{
	protected IMediator _mediator;

	public Step(IMediator mediator)
    {
        _mediator = mediator;
    }
}