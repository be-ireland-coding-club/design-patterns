namespace AbstractFactoryPattern.PaymentFees{
    public class KioskCardFeeCalculator : ICalculatePaymentFees{
        private const decimal _lowPaymentFee = .20M;
        private const decimal _highPaymentFee = .05M;
        public decimal CalculateFee(decimal subtotal){
            if(subtotal < 0) throw new ArgumentException("Subtotal cannot be negative");
            var totalFee = 0.0M;
            if(subtotal > 100){
                totalFee += (subtotal-100) * _highPaymentFee;
                totalFee += 100 * _lowPaymentFee;
            }
            else{
                totalFee += subtotal * _lowPaymentFee;
            }
            return totalFee;
        }
    }
}