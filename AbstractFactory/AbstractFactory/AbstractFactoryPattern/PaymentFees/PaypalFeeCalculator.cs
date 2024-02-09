namespace AbstractFactoryPattern.PaymentFees{
    public class PaypalFeeCalculator : ICalculatePaymentFees{
        private const decimal _fee = .2M;

        public decimal CalculateFee(decimal subtotal){
            return subtotal * _fee;
        }
    }
}