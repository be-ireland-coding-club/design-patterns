namespace FactoryPattern.FeeCalculators{
    internal class CashFeeCalculator : ICalculateFee
    {
        private readonly decimal _feeRate = .1M;
        public decimal CalculateFee(decimal price)
        {
            if(price < 0) throw new ArgumentException("Price must be non-negative");
            return price * _feeRate;
        }
    }
}