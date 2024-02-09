using AbstractFactoryPattern.Enums;
using AbstractFactoryPattern.PaymentFees;

namespace AbstractFactoryPattern.Factories{
    public interface IFeeFactory{
        ICalculatePaymentFees GetFeeCalculator(PaymentType paymentType);
    }
}