using System;

namespace BridgeProject.Delivery
{
    class Fast : IDelivery
    {
        public void SetDelivery()
        {
            Console.WriteLine("Fast");
        }
    }
}
