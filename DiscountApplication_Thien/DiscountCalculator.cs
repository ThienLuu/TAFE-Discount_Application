using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApplication_Thien
{
    public static class DiscountCalculator
    {
        //fields & properties
        //public string InputPrice { get; set; }

        //methods
        public static string calculate(string inputPrice, string discount)
        {
            double price;
            //double price = double.Parse(inputPrice);
            double discountInt;
            //double discountInt = double.Parse(discount);

            bool priceSuccessful = double.TryParse(inputPrice, out price);
            bool discountSuccessful = double.TryParse(discount, out discountInt);

            string finalPrice;
            if (priceSuccessful == true && discountSuccessful == true)
            {
                
                //double actualDiscount = (double)price / 100 * discountInt;
                //double finalPriceDouble = price - actualDiscount;

                finalPrice = calculatePricing(price, discountInt).ToString();
            }
            else
            {
                finalPrice = "Error - Enter Numbers Only";
            }

            return finalPrice;
        }

        static double calculatePricing(double price, double discountInt)
        {
            double actualDiscount = price / 100 * discountInt;
            double finalPriceDouble = price - actualDiscount;

            return finalPriceDouble;
        }
    }
}