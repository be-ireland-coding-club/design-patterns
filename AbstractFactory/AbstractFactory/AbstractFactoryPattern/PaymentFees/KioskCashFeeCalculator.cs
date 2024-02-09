namespace AbstractFactoryPattern.PaymentFees{
    public class KioskCashFeeCalculator : ICalculatePaymentFees{
        private const decimal _fee = .10M;
        public decimal CalculateFee(decimal subtotal){
            if(subtotal < 0) throw new ArgumentException("Subtotal cannot be negative");
            return subtotal * _fee;
        }
    }
}