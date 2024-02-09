using FactoryPattern.FeeCalculators;

namespace FactoryPattern.FeeFactories{
    public static class FeeFactory{
        public static ICalculateFee GetFeeCalculator(PaymentType paymentType){
            return paymentType switch
            {
                PaymentType.Cash => new CashFeeCalculator(),
                PaymentType.Card => new CardFeeCalculator(),
                _ => throw new ArgumentOutOfRangeException("Invalid payment method"),
            };
        }
    }
}