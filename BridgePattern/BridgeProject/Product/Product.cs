using BridgeProject.Delivery;

namespace BridgeProject.Product
{
    abstract class Product
    {
        protected IDelivery _delivery;

        public Product(IDelivery delivery)
        {
            _delivery = delivery;
        }

        public abstract void PrepareOrder();
    }
}
