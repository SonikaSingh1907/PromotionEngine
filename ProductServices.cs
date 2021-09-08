using System.Collections.Generic;
using PromotionEngine.Models;

namespace PromotionEngine.IProductServices
{
    public class ProductServices : IProductServices
    {
        public ProductServices()
        {

        }

       public int GetTotalPrice(List<Product> products)
        {
            int counterA = 0;
            int priceA = 50;
            int counterB = 0;
            int priceB = 30;
            int counterC = 0;
            int priceC = 20;
            int counterD = 0;
            int priceD = 15;

            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterA = counterA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterB = counterB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    counterC = counterC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    counterD = counterD + 1;
                }
            }

            //Calculate the total price of each product and returns sum of it
            int totalPriceOfA = (counterA / 3) * 130 + (counterA % 3 * priceA);
            int totalPriceOfB = (counterB / 2) * 45 + (counterB % 2 * priceB);
            int totalPriceOfC = (counterC * priceC);
            int totalPriceOfD = (counterD * priceD);
            return totalPriceOfA + totalPriceOfB + totalPriceOfC + totalPriceOfD;
        }
    }
}
