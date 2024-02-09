using AbstractFactoryPattern.Enums;
using AbstractFactoryPattern.PaymentFees;

namespace AbstractFactoryPattern.Factories{
    public class OnlinePaymentFeeFactory : IFeeFactory{
        public ICalculatePaymentFees GetFeeCalculator(PaymentType paymentType){
            return paymentType switch
            {
                PaymentType.Cash => new OnlineCardFeeCalculator(),
                PaymentType.Card => new PaypalFeeCalculator(),
                _ => throw new ArgumentOutOfRangeException("Unknown payment type"),
            };
        }
    }
}