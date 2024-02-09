using FactoryPattern.FeeFactories;

var price = 90M;
var cashFeeCalculator = FeeFactory.GetFeeCalculator(FactoryPattern.PaymentType.Cash);
Console.WriteLine($"Cash fee on subtotal of {price} is {cashFeeCalculator.CalculateFee(price)}");

price = 100M;
var cardFeeCalculator = FeeFactory.GetFeeCalculator(FactoryPattern.PaymentType.Card);
Console.WriteLine($"Card fee on subtotal of {price} is {cardFeeCalculator.CalculateFee(price)}");

price = 200.50M;
Console.WriteLine($"Card fee on subtotal of {price} is {cardFeeCalculator.CalculateFee(price)}");