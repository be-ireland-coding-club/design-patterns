namespace AbstractFactoryPattern.PaymentFees{
    public interface ICalculatePaymentFees{
        decimal CalculateFee(decimal subtotal);
    }
}