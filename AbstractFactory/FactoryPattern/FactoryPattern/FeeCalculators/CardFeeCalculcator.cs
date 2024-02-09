namespace FactoryPattern.FeeCalculators{
    internal class CardFeeCalculator : ICalculateFee
    {
        private readonly decimal _firstOneHundredFeeRate = .2M;
        private readonly decimal _greaterThanOneHundredFeeRate = .05M;
        public decimal CalculateFee(decimal price)
        {
            if(price < 0) throw new ArgumentException("Price must be non-negative");
            decimal fee;
            if(price <= 100){
                fee = price * _firstOneHundredFeeRate;
            }
            else{
                fee = 100 * _firstOneHundredFeeRate;
                fee += (price - 100) * _greaterThanOneHundredFeeRate;
            }
            return fee;
        }
    }
}