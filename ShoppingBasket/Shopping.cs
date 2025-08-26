using System.Numerics;

namespace ShoppingBasket
{
    public class Shop
    {
        public decimal shoppingBasket(string input)
        {
            decimal totalPriceOfBasket = 0.0m;
            int melonOffer = 0;
            int limeOffer = 0;
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("No items provided.");
                return totalPriceOfBasket;
            }

            List<string> items = new List<string>(input.Split(','));

            foreach (var item in items)
            {
                if (item.ToLower().Trim() == "apple")
                {
                    totalPriceOfBasket = totalPriceOfBasket + 0.35m;
                } 
                else if (item.ToLower().Trim() == "banana")
                {
                    totalPriceOfBasket = totalPriceOfBasket + 0.20m;
                }
                else if (item.ToLower().Trim() == "melon")
                {
                    if (melonOffer == 1)
                    {
                        totalPriceOfBasket = totalPriceOfBasket + 0.0m;
                        melonOffer = 0;
                    }
                    else
                    {
                        totalPriceOfBasket = totalPriceOfBasket + 0.50m;
                        melonOffer = melonOffer + 1;
                    }
                }
                else if (item.ToLower().Trim() == "lime")
                {
                    if (limeOffer == 2)
                    {
                        totalPriceOfBasket = totalPriceOfBasket + 0.0m;
                        limeOffer = 0;
                    }
                    else
                    {
                        totalPriceOfBasket = totalPriceOfBasket + 0.15m;
                        limeOffer = limeOffer + 1;
                    }                  
                }
            }
            return totalPriceOfBasket;
        }
    }
    internal class Shopping
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter shopping items separated by commas:");
            string input = Console.ReadLine();

            Shop priceCalculator = new Shop();
            decimal totalPrice = priceCalculator.shoppingBasket(input);
            Console.WriteLine("Total price of basket:"+totalPrice);
            Console.ReadKey();
        }
    }
}
