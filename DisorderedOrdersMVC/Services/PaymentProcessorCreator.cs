namespace DisorderedOrdersMVC.Services
{
    public static class PaymentProcessorCreator
    {
        public static IPaymentProcessor CreateProcessor(string paymentType)
        {
            switch (paymentType?.ToLower())
            {
                case "bitcoin":
                    return new BitcoinProcessor();
                case "paypal":
                    return new PayPalProcessor();
                default:
                    return new CreditCardProcessor();
            }
        }
    }
}