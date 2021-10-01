namespace MediatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderCreationMediator orderCreationMediator = new OrderCreationMediator();
            orderCreationMediator.CreateOrder();

            OrderEditMediator orderEditMediator = new OrderEditMediator();
            orderEditMediator.EditOrder();
        }
    }
}
