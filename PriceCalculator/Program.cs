namespace PriceCalculator
{
    internal class Program
    {
        class PriceCalculator
        {
            public enum Season
            {
                Autumn = 1,
                Spring = 2,
                Summer = 3,
                Winter = 4
            }

            public enum Discount
            {
                None = 0,
                SecondVisit = 10,
                Vip = 20
            }

            public static double TotalPrice(double pricePerDay, int numberOfDays, Season season, Discount discount)
            {
                double seasonMultiplier = (double)season;
                double totalPrice = pricePerDay * numberOfDays * seasonMultiplier;
                double discountType = (double)discount / 100;
                return totalPrice - (totalPrice * discountType);
            }

            static void Main(string[] args)
            {
                Console.WriteLine("Enter Number of Days: ");
                int numberOfDays = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Number of Price/Day: ");
                double pricePerDay = double.Parse(Console.ReadLine());
                PriceCalculator.Season season = PriceCalculator.Season.Winter;
                PriceCalculator.Discount discount = PriceCalculator.Discount.SecondVisit;
                double totalPrice = PriceCalculator.TotalPrice(pricePerDay, numberOfDays, season, discount);
                Console.WriteLine("Total Price: " + totalPrice);
            }
        }
    }
}