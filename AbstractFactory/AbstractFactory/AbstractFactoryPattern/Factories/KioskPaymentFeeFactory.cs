using AbstractFactoryPattern.Enums;
using AbstractFactoryPattern.PaymentFees;

namespace AbstractFactoryPattern.Factories{
    public class KioskPaymentFeeCalculatorFactory : IFeeFactory{
        public ICalculatePaymentFees GetFeeCalculator(PaymentType paymentType){
            return paymentType switch
            {
                PaymentType.Cash => new KioskCashFeeCalculator(),
                PaymentType.Card => new KioskCardFeeCalculator(),
                _ => throw new ArgumentOutOfRangeException("Unknown payment type"),
            };
        }
    }
}