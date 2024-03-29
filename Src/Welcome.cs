namespace SoGoodSushi.Src
{
    public static class Welcome
    {
        private static string WelcomeMessage { get; } = "\nWelcome to So Good Sushi, where all your sushi dreams come true!\n";

        public static string WelcomeCustomer()
        {
            Console.WriteLine(WelcomeMessage);
            Console.WriteLine("What's your name?");
            string? customerName = Console.ReadLine();
            if (string.IsNullOrEmpty(customerName))
                customerName = "Valued Customer";
            Console.Clear();
            Console.WriteLine("\nWe're happy to have you here, " + customerName + "!");
            return customerName;
        }


    }
}
