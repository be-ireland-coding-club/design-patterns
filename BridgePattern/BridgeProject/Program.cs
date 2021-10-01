using BridgeProject.Delivery;
using BridgeProject.Product;

namespace BridgeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var standardSlow = new Standard(new Slow());
            standardSlow.PrepareOrder();

            var deluxeFast = new Deluxe(new Fast());
            deluxeFast.PrepareOrder();

            var deluxeSlow = new Deluxe(new Slow());
            deluxeSlow.PrepareOrder();
        }
    }
}
