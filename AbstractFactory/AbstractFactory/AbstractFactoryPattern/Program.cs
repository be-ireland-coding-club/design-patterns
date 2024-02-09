using AbstractFactoryPattern.Enums;
using AbstractFactoryPattern.Factories;

string operation;
do{
    string medium;
    do{
        Console.WriteLine("Which medium is being used to purchase item\n1 - Kiosk\n2 - Online");
        medium = Console.ReadLine() ?? string.Empty;
    } while(medium != "1" && medium != "2");
    var paymentMedium = medium == "1" ? PaymentMedium.Kiosk : PaymentMedium.Online;

    var feeMediumFactory = PaymentMediumFactory.GetFeeFactory(paymentMedium);

    Console.WriteLine("Input Subtotal");
    var subtotalString = Console.ReadLine();
    if(!decimal.TryParse(subtotalString, out decimal subtotal))
        throw new ArgumentException("Subtotal must be a decimal");
    string paymentMethodString;
    do{
        Console.WriteLine("What is the payment method\n1 - Card\n2 - Cash");
        paymentMethodString = Console.ReadLine() ?? string.Empty;
    } while(medium != "1" && medium != "2");
    var paymentMethod = paymentMethodString == "1" ? PaymentType.Card : PaymentType.Cash;

    var feeFactory = feeMediumFactory.GetFeeCalculator(paymentMethod);
    var fee = feeFactory.CalculateFee(subtotal);
    Console.WriteLine($"Subtotal: {subtotal}\nFee: {fee}\nTotal: {subtotal+fee}");
    
    Console.WriteLine("Select option\n1 - Calculate another fee\nAny other key - exit");
    operation = Console.ReadLine() ?? string.Empty;
} while(operation == "1");