using BridgeProject.Delivery;
using System;

namespace BridgeProject.Product
{
    class Standard : Product
    {
        public Standard(IDelivery delivery) : base(delivery)
        {
        }

        public override void PrepareOrder()
        {
            Console.Write("Standard with delivery: ");
            _delivery.SetDelivery();
        }
    }
}
