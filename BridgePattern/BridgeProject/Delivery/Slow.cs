using System;

namespace BridgeProject.Delivery
{
    class Slow : IDelivery
    {
        public void SetDelivery()
        {
            Console.WriteLine("Slow");
        }
    }
}
