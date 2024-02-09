using AbstractFactoryPattern.Enums;

namespace AbstractFactoryPattern.Factories{
    public static class PaymentMediumFactory{
        public static IFeeFactory GetFeeFactory(PaymentMedium paymentMedium){
            return paymentMedium switch
            {
                PaymentMedium.Online => new OnlinePaymentFeeFactory(),
                PaymentMedium.Kiosk => new KioskPaymentFeeCalculatorFactory(),
                _ => throw new ArgumentOutOfRangeException("Unknown payment type"),
            };
        }
    }
}