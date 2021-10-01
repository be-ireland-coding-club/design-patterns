using BridgeProject.Delivery;
using System;

namespace BridgeProject.Product
{
    class Deluxe : Product
    {
        public Deluxe(IDelivery delivery) : base(delivery)
        {
        }

        public override void PrepareOrder()
        {
            Console.Write("Deluxe with delivery: ");
            _delivery.SetDelivery();
        }
    }
}
